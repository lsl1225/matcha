namespace Cafe.Matcha.Constant {
    internal class PacketStructure {
        public enum FFXIVARR_SEGMENT_TYPE {
            SEGMENTTYPE_SESSIONINIT = 1,
            SEGMENTTYPE_IPC = 3,
            SEGMENTTYPE_KEEPALIVE = 7,
            //SEGMENTTYPE_RESPONSE = 8,
            SEGMENTTYPE_ENCRYPTIONINIT = 9,
        };

        struct FFXIVARR_PACKET_HEADER {
            byte[] magic;
            byte timestamp;
            byte size;
            byte connectionType;
            byte segmentCount;
            byte unknown_20;
            byte isCompressed;
            byte unknown_24;
        };

        struct FFXIVARR_PACKET_SEGMENT_HEADER {
            byte size;
            byte source_actor;
            byte target_actor;
            FFXIVARR_SEGMENT_TYPE type;
            byte padding;
        };

        struct FFXIVARR_IPC_HEADER {
            byte reserved;
            byte type;
            byte padding;
            byte serverId;
            byte timestamp;
            byte padding1;
        };
    }
}
