// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: video_h265cfg.proto

#pragma warning disable 0612, 1591, 3021
namespace apollo.drivers.video.config
{

    [global::ProtoBuf.ProtoContract()]
    public partial class CameraH265Config : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public CameraH265Config()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1, IsRequired = true)]
        public uint udp_port { get; set; }

        [global::ProtoBuf.ProtoMember(2, IsRequired = true)]
        public string frame_id { get; set; }

        [global::ProtoBuf.ProtoMember(3, IsRequired = true)]
        public string pixel_format { get; set; }

        [global::ProtoBuf.ProtoMember(4, IsRequired = true)]
        public uint record { get; set; }

        [global::ProtoBuf.ProtoMember(5, IsRequired = true)]
        public uint width { get; set; }

        [global::ProtoBuf.ProtoMember(6, IsRequired = true)]
        public uint height { get; set; }

        [global::ProtoBuf.ProtoMember(7, IsRequired = true)]
        public uint frame_rate { get; set; }

        [global::ProtoBuf.ProtoMember(8, IsRequired = true)]
        public bool monochrome { get; set; }

        [global::ProtoBuf.ProtoMember(9, IsRequired = true)]
        public int brightness { get; set; }

        [global::ProtoBuf.ProtoMember(10, IsRequired = true)]
        public int contrast { get; set; }

        [global::ProtoBuf.ProtoMember(11, IsRequired = true)]
        public int saturation { get; set; }

        [global::ProtoBuf.ProtoMember(12, IsRequired = true)]
        public int sharpness { get; set; }

        [global::ProtoBuf.ProtoMember(13, IsRequired = true)]
        public int gain { get; set; }

        [global::ProtoBuf.ProtoMember(14, IsRequired = true)]
        public bool auto_focus { get; set; }

        [global::ProtoBuf.ProtoMember(15, IsRequired = true)]
        public int focus { get; set; }

        [global::ProtoBuf.ProtoMember(16, IsRequired = true)]
        public bool auto_exposure { get; set; }

        [global::ProtoBuf.ProtoMember(17, IsRequired = true)]
        public int exposure { get; set; }

        [global::ProtoBuf.ProtoMember(18, IsRequired = true)]
        public bool auto_white_balance { get; set; }

        [global::ProtoBuf.ProtoMember(19, IsRequired = true)]
        public int white_balance { get; set; }

        [global::ProtoBuf.ProtoMember(20, IsRequired = true)]
        public uint bytes_per_pixel { get; set; }

        [global::ProtoBuf.ProtoMember(21, IsRequired = true)]
        public string trigger_param { get; set; }

        [global::ProtoBuf.ProtoMember(22, IsRequired = true)]
        public uint metric_error_code { get; set; }

        [global::ProtoBuf.ProtoMember(23, IsRequired = true)]
        public int fpga_dev_number { get; set; }

        [global::ProtoBuf.ProtoMember(24, IsRequired = true)]
        public int camera_seq_number { get; set; }

        [global::ProtoBuf.ProtoMember(25)]
        public CompressConfig compress_conf { get; set; }

        [global::ProtoBuf.ProtoContract()]
        public partial class CompressConfig : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            {
                return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
            }
            public CompressConfig()
            {
                OnConstructor();
            }

            partial void OnConstructor();

            [global::ProtoBuf.ProtoMember(1)]
            [global::System.ComponentModel.DefaultValue("")]
            public string output_channel
            {
                get { return __pbn__output_channel ?? ""; }
                set { __pbn__output_channel = value; }
            }
            public bool ShouldSerializeoutput_channel()
            {
                return __pbn__output_channel != null;
            }
            public void Resetoutput_channel()
            {
                __pbn__output_channel = null;
            }
            private string __pbn__output_channel;

            [global::ProtoBuf.ProtoMember(2)]
            [global::System.ComponentModel.DefaultValue(20)]
            public uint image_pool_size
            {
                get { return __pbn__image_pool_size ?? 20; }
                set { __pbn__image_pool_size = value; }
            }
            public bool ShouldSerializeimage_pool_size()
            {
                return __pbn__image_pool_size != null;
            }
            public void Resetimage_pool_size()
            {
                __pbn__image_pool_size = null;
            }
            private uint? __pbn__image_pool_size;

        }

    }

}

#pragma warning restore 0612, 1591, 3021
