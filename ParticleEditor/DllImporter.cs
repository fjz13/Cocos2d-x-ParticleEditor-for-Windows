using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;

namespace MedusaSimulator
{
    class DllImporter
    {
        [DllImport("kernel32.dll")]
        public static extern IntPtr LoadLibrary(string path);

        [DllImport("kernel32.dll")]
        public static extern IntPtr GetProcAddress(IntPtr lib, string funcName);

        [DllImport("kernel32.dll")]
        public static extern bool FreeLibrary(IntPtr lib);

        private IntPtr mDll = IntPtr.Zero;

        public bool IsLoaded
        {
            get
            {
                return mDll != IntPtr.Zero;
            }
        }
        public DllImporter()
        {
            //var myAssemblyName = new AssemblyName { Name = "DllImporter" };
            //var myAssemblyBuilder = AppDomain.CurrentDomain.DefineDynamicAssembly(myAssemblyName, AssemblyBuilderAccess.Run);
            //mModuleBuilder = myAssemblyBuilder.DefineDynamicModule("DllImporter");
        }

        public void Open(string path)
        {
            if (mDll == IntPtr.Zero)
            {
                mDll = LoadLibrary(path);
            }
        }

        public void Close()
        {
            if (mDll != IntPtr.Zero)
            {
                FreeLibrary(mDll);
                mDll = IntPtr.Zero;
            }

        }

        //private readonly ModuleBuilder mModuleBuilder;
        private readonly Dictionary<Type, MethodInfo> mMethods = new Dictionary<Type, MethodInfo>();

        public T InvokeMethod<T>() where T : class
        {
            var methodType = typeof(T);
            var methodPtr = GetProcAddress(mDll, methodType.Name);
            var callback = Marshal.GetDelegateForFunctionPointer(methodPtr, methodType);
            return callback as T;
        }

        public TR Invoke<T, TR>(params object[] parameters) where T : class
        {
            var delegateType = typeof(T);
            if (mMethods.ContainsKey(delegateType))
            {
                var methodInfo = mMethods[delegateType];
                return (TR)methodInfo.Invoke(null, parameters);
            }

            var myAssemblyName = new AssemblyName { Name = "DllImporter" };
            var myAssemblyBuilder = AppDomain.CurrentDomain.DefineDynamicAssembly(myAssemblyName, AssemblyBuilderAccess.Run);
            var myModuleBuilder = myAssemblyBuilder.DefineDynamicModule("DllImporter");


            var delegateMethod = delegateType.GetMethod("Invoke");
            var paramInfos = delegateMethod.GetParameters();
            var paramTypes = paramInfos.Select(parameterInfo => parameterInfo.ParameterType).ToArray();

            var methodPtr = GetProcAddress(mDll, delegateType.Name);

            var myMethodBuilder = myModuleBuilder.DefineGlobalMethod(delegateType.Name, MethodAttributes.Public | MethodAttributes.Static, delegateMethod.ReturnType, paramTypes);
            var il = myMethodBuilder.GetILGenerator();
            for (var i = 0; i < paramInfos.Length; i++)
            {
                il.Emit(OpCodes.Ldarg, i);  //by value
                //IL.Emit(OpCodes.Ldarga, i);   //by ref
            }

            il.Emit(OpCodes.Ldc_I4, methodPtr.ToInt32());

            //switch (IntPtr.Size)
            //{
            //    case 4:
            //        il.Emit(OpCodes.Ldc_I4, methodPtr.ToInt32());
            //        break;
            //    case 8:
            //        il.Emit(OpCodes.Ldc_I8, methodPtr.ToInt64());
            //        break;
            //    default:
            //        throw new PlatformNotSupportedException();
            //}

            il.EmitCalli(OpCodes.Calli, CallingConvention.StdCall, delegateMethod.ReturnType, paramTypes);
            il.Emit(OpCodes.Ret);
            myModuleBuilder.CreateGlobalFunctions();

            var myMethodInfo = myModuleBuilder.GetMethod(delegateType.Name);
            mMethods[delegateType] = myMethodInfo;

            return (TR)myMethodInfo.Invoke(null, parameters);

        }
    }
}
