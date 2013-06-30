#ifndef __HELLOWORLD_SCENE_H__
#define __HELLOWORLD_SCENE_H__

#include "cocos2d.h"
using namespace cocos2d;

class HelloWorld : public cocos2d::CCLayer
{
public:
	// Here's a difference. Method 'init' in cocos2d-x returns bool, instead of returning 'id' in cocos2d-iphone
	virtual bool init();  

	// there's no 'id' in cpp, so we recommand to return the exactly class pointer
	static cocos2d::CCScene* scene();
	
	// a selector callback

	// implement the "static node()" method manually
	 CREATE_FUNC(HelloWorld);

	static void HelloWorld::ChangeParticle(float scale,bool isBackgroundMove,float angle,float angleVar,int destBlendFunc,int srcBlendFunc,float duration,float emissionRate,int emiiterMode,
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

	static CCParticleSystem* mEmiiter;
	static CCSprite* mBackground;
	static bool mIsBackgroundMove;
};

#endif // __HELLOWORLD_SCENE_H__
