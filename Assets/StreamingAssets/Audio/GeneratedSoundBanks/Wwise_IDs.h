/////////////////////////////////////////////////////////////////////////////////////////////////////
//
// Audiokinetic Wwise generated include file. Do not edit.
//
/////////////////////////////////////////////////////////////////////////////////////////////////////

#ifndef __WWISE_IDS_H__
#define __WWISE_IDS_H__

#include <AK/SoundEngine/Common/AkTypes.h>

namespace AK
{
    namespace EVENTS
    {
        static const AkUniqueID PLAY_AMB_CITY_LP = 584628495U;
        static const AkUniqueID PLAY_AMB_FOREST_LP = 149137005U;
        static const AkUniqueID PLAY_AMB_INTERIOR_LP = 93749488U;
        static const AkUniqueID PLAY_FLY_FOOTSTEP = 958544762U;
        static const AkUniqueID PLAY_FLY_FOOTSTEP_CONCRETE = 3826579360U;
        static const AkUniqueID PLAY_FLY_FOOTSTEP_GRASS = 4240657477U;
        static const AkUniqueID PLAY_IMP_PICKUP = 3369882767U;
        static const AkUniqueID PLAY_IMP_WALL = 2242885151U;
        static const AkUniqueID PLAY_MUS_BGM = 4268572028U;
        static const AkUniqueID PLAY_MVT_BALLROLLING_LP = 4193143717U;
        static const AkUniqueID PLAY_UI_WIN = 2823495579U;
        static const AkUniqueID STOP_AMB_CITY_LP = 2646299865U;
        static const AkUniqueID STOP_AMB_FOREST_LP = 705314987U;
        static const AkUniqueID STOP_AMB_INTERIOR_LP = 2159561926U;
    } // namespace EVENTS

    namespace STATES
    {
        namespace STA_GAMESTATE
        {
            static const AkUniqueID GROUP = 530992273U;

            namespace STATE
            {
                static const AkUniqueID IDLE = 1874288895U;
                static const AkUniqueID NONE = 748895195U;
                static const AkUniqueID PICKEDUP = 3593755026U;
                static const AkUniqueID WIN = 979765101U;
            } // namespace STATE
        } // namespace STA_GAMESTATE

    } // namespace STATES

    namespace SWITCHES
    {
        namespace SWI_FOOTSTEPMATERIAL
        {
            static const AkUniqueID GROUP = 3045844422U;

            namespace SWITCH
            {
                static const AkUniqueID CONCRETE = 841620460U;
                static const AkUniqueID GRASS = 4248645337U;
            } // namespace SWITCH
        } // namespace SWI_FOOTSTEPMATERIAL

    } // namespace SWITCHES

    namespace GAME_PARAMETERS
    {
        static const AkUniqueID RTPC_BALLSPEED = 3709966389U;
        static const AkUniqueID RTPC_COLLISIONVELOCITYNORMALIZED = 1573010119U;
        static const AkUniqueID RTPC_PLAYERDISTANCE = 3045223865U;
        static const AkUniqueID RTPC_PLAYERSPEED = 2653406601U;
    } // namespace GAME_PARAMETERS

    namespace BANKS
    {
        static const AkUniqueID INIT = 1355168291U;
        static const AkUniqueID MAINSOUNDBANK = 534561221U;
    } // namespace BANKS

    namespace BUSSES
    {
        static const AkUniqueID MASTER_AUDIO_BUS = 3803692087U;
        static const AkUniqueID MUS = 712897226U;
        static const AkUniqueID SFX = 393239870U;
        static const AkUniqueID UI = 1551306167U;
    } // namespace BUSSES

    namespace AUDIO_DEVICES
    {
        static const AkUniqueID NO_OUTPUT = 2317455096U;
        static const AkUniqueID SYSTEM = 3859886410U;
    } // namespace AUDIO_DEVICES

}// namespace AK

#endif // __WWISE_IDS_H__
