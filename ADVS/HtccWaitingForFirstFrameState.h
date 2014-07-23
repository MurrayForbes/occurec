#ifndef HTCC_WAITING_FOR_FIRST_FRAME_STATE
#define HTCC_WAITING_FOR_FIRST_FRAME_STATE

#include "HtccState.h"

class HtccWaitingForFirstFrameState: public HtccState
{
private:
	HtccMessage* m_SecondFrameStartTimestamp;
	HtccMessage* startTimestamp;
	bool m_FirstFrameArrived;
public:
	static HtccWaitingForFirstFrameState* s_pInstance;
	static HtccWaitingForFirstFrameState* Instance();


	virtual void Initialise(HtccStateMachine *context);
	virtual void Finalise(HtccStateMachine *context);
	virtual HtccMessage* ReceivePacket(HtccStateMachine *context, unsigned char* packet);
	virtual bool ProcessOneSecondTick(HtccStateMachine *context);
};

#endif