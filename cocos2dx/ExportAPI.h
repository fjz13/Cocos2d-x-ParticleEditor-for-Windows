#pragma once

//#include <windows.h>

#define MEDUSA_EXPORT_API __declspec(dllexport) 
#include "cocos2d.h"

extern "C"
{
	
	//////////////////////////////////////////////////////////////////////////

	MEDUSA_EXPORT_API bool MInitializeApplication(HWND hwnd);
	MEDUSA_EXPORT_API bool MGameLoop(float interval);


	MEDUSA_EXPORT_API bool MParticleChanged(float scale, bool isBackgroundMove,float angle,float angleVar,int destBlendFunc,int srcBlendFunc,float duration,float emissionRate,int emiiterMode,
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
		);

	MEDUSA_EXPORT_API bool MGameCleanUp();
};


