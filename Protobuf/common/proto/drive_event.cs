// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: drive_event.proto

#pragma warning disable 0612, 1591, 3021
namespace apollo.common
{

    [global::ProtoBuf.ProtoContract()]
    public partial class DriveEvent : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public DriveEvent()
        {
            type = new global::System.Collections.Generic.List<Type>();
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public Header header { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string @event
        {
            get { return __pbn__event ?? ""; }
            set { __pbn__event = value; }
        }
        public bool ShouldSerializeevent()
        {
            return __pbn__event != null;
        }
        public void Resetevent()
        {
            __pbn__event = null;
        }
        private string __pbn__event;

        [global::ProtoBuf.ProtoMember(3)]
        public global::apollo.localization.Pose location { get; set; }

        [global::ProtoBuf.ProtoMember(4)]
        public global::System.Collections.Generic.List<Type> type { get; private set; }

        [global::ProtoBuf.ProtoMember(5)]
        public bool is_reportable
        {
            get { return __pbn__is_reportable.GetValueOrDefault(); }
            set { __pbn__is_reportable = value; }
        }
        public bool ShouldSerializeis_reportable()
        {
            return __pbn__is_reportable != null;
        }
        public void Resetis_reportable()
        {
            __pbn__is_reportable = null;
        }
        private bool? __pbn__is_reportable;

        [global::ProtoBuf.ProtoContract()]
        public enum Type
        {
            [global::ProtoBuf.ProtoEnum(Name = @"CRITICAL")]
            Critical = 0,
            [global::ProtoBuf.ProtoEnum(Name = @"PROBLEM")]
            Problem = 1,
            [global::ProtoBuf.ProtoEnum(Name = @"DESIRED")]
            Desired = 2,
            [global::ProtoBuf.ProtoEnum(Name = @"OUT_OF_SCOPE")]
            OutOfScope = 3,
        }

    }

}

#pragma warning restore 0612, 1591, 3021
