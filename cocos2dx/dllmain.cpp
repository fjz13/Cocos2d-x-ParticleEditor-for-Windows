// dllmain.cpp : Defines the entry point for the DLL application.
//#include <windows.h>
#include "cocos2d.h"

BOOL APIENTRY DllMain( HMODULE hModule,DWORD  ul_reason_for_call,LPVOID lpReserved)
{
	switch (ul_reason_for_call)
	{
	case DLL_PROCESS_ATTACH:
	case DLL_THREAD_ATTACH:

		break;
	case DLL_THREAD_DETACH:
	case DLL_PROCESS_DETACH:
		//instance will be deleted automatically
		break;
	}
	return TRUE;
}

