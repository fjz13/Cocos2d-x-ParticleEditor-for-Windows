#include "ExportAPI.h"

//this file will only be included in Win32
#include "cocos2d.h"
#include "AppDelegate.h"
#include "HelloWorldScene.h"

extern "C"
{
	MEDUSA_EXPORT_API bool MInitializeApplication( HWND hwnd )
	{

		cocos2d::CCEGLView::SetParentHwnd(hwnd);

		// create the application instance
		AppDelegate app;


		CCEGLView* eglView = CCEGLView::sharedOpenGLView();
		eglView->setViewName("HelloCpp");
		eglView->setFrameSize(1024, 768);
		// The resolution of ipad3 is very large. In general, PC's resolution is smaller than it.
		// So we need to invoke 'setFrameZoomFactor'(only valid on desktop(win32, mac, linux)) to make the window smaller.
		eglView->setFrameZoomFactor(1.f);


		CCApplication::sharedApplication()->run();
		return true;
	}


	MEDUSA_EXPORT_API bool MGameCleanUp()
	{

		cocos2d::CCEGLView::Destroy();

		cocos2d::CCDirector::sharedDirector()->end();

		return true;
	}


	MEDUSA_EXPORT_API bool MGameLoop( float interval )
	{
		cocos2d::CCDirector::sharedDirector()->mainLoop();
		return true;
	}


	MEDUSA_EXPORT_API bool MParticleChanged(float scale,bool isBackgroundMove,float angle,float angleVar,int destBlendFunc,int srcBlendFunc,float duration,float emissionRate,int emiiterMode,
		GLbyte endColorR,GLbyte endColorG,GLbyte endColorB,GLbyte endColorA,
		GLbyte endColorVarR,GLbyte endColorVarG,GLbyte endColorVarB,GLbyte endColorVarA,
		float endRadius,float endRadiusVar,
		float endSize,float endSizeVar,
		float endSpin,float endSpinVar,
		float gravityX,float gravityY,
		bool isAutoRemoveOnFinish,
		float life,float lifeVar,
		int positionType,
		float positionVarX,float positionVarY,
		float radialAccel,float radialAccelVar,
		float rotatePerSecond,float rotatePerSecondVar,
		float sourcePositionX,float sourcePositionY,
		float speed,float speedVar,
		GLbyte startColorR,GLbyte startColorG,GLbyte startColorB,GLbyte startColorA,
		GLbyte startColorVarR,GLbyte startColorVarG,GLbyte startColorVarB,GLbyte startColorVarA,
		float startRadius,float startRadiusVar,
		float startSize,float startSizeVar,
		float startSpin,float startSpinVar,
		float tangentialAccel,float tangentialAccelVar,
		char* plistPath,char* texturePath,char* textureImageData,
		unsigned int totalParticles
		)
	{
		HelloWorld::ChangeParticle(scale, isBackgroundMove,angle,angleVar,destBlendFunc,srcBlendFunc,duration,emissionRate,emiiterMode,
			endColorR,endColorG,endColorB,endColorA,
			endColorVarR,endColorVarG,endColorVarB,endColorVarA,
			endRadius,endRadiusVar,
			endSize,endSizeVar,
			endSpin,endSpinVar,
			gravityX,gravityY,
			isAutoRemoveOnFinish,
			life,lifeVar,
			positionType,
			positionVarX,positionVarY,
			radialAccel,radialAccelVar,
			rotatePerSecond,rotatePerSecondVar,
			sourcePositionX,sourcePositionY,
			speed,speedVar,
			startColorR,startColorG,startColorB,startColorA,
			startColorVarR,startColorVarG,startColorVarB,startColorVarA,
			startRadius,startRadiusVar,startSize,startSizeVar,
			startSpin,startSpinVar,tangentialAccel,tangentialAccelVar,plistPath,texturePath,textureImageData,totalParticles);
		return true;
	}
}

