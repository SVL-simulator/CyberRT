// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: network_layers.proto

#pragma warning disable 0612, 1591, 3021
namespace apollo.prediction
{

    [global::ProtoBuf.ProtoContract()]
    public partial class TensorParameter : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public TensorParameter()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1, IsPacked = true)]
        public float[] data { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public int[] shape { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class InputParameter : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public InputParameter()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public int[] input_shape { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string dtype
        {
            get { return __pbn__dtype ?? ""; }
            set { __pbn__dtype = value; }
        }
        public bool ShouldSerializedtype()
        {
            return __pbn__dtype != null;
        }
        public void Resetdtype()
        {
            __pbn__dtype = null;
        }
        private string __pbn__dtype;

        [global::ProtoBuf.ProtoMember(3)]
        public bool sparse
        {
            get { return __pbn__sparse.GetValueOrDefault(); }
            set { __pbn__sparse = value; }
        }
        public bool ShouldSerializesparse()
        {
            return __pbn__sparse != null;
        }
        public void Resetsparse()
        {
            __pbn__sparse = null;
        }
        private bool? __pbn__sparse;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class DenseParameter : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public DenseParameter()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public int units
        {
            get { return __pbn__units.GetValueOrDefault(); }
            set { __pbn__units = value; }
        }
        public bool ShouldSerializeunits()
        {
            return __pbn__units != null;
        }
        public void Resetunits()
        {
            __pbn__units = null;
        }
        private int? __pbn__units;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string activation
        {
            get { return __pbn__activation ?? ""; }
            set { __pbn__activation = value; }
        }
        public bool ShouldSerializeactivation()
        {
            return __pbn__activation != null;
        }
        public void Resetactivation()
        {
            __pbn__activation = null;
        }
        private string __pbn__activation;

        [global::ProtoBuf.ProtoMember(3)]
        public bool use_bias
        {
            get { return __pbn__use_bias.GetValueOrDefault(); }
            set { __pbn__use_bias = value; }
        }
        public bool ShouldSerializeuse_bias()
        {
            return __pbn__use_bias != null;
        }
        public void Resetuse_bias()
        {
            __pbn__use_bias = null;
        }
        private bool? __pbn__use_bias;

        [global::ProtoBuf.ProtoMember(4)]
        public TensorParameter weights { get; set; }

        [global::ProtoBuf.ProtoMember(5)]
        public TensorParameter bias { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Conv1dParameter : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public Conv1dParameter()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public int[] shape { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public bool use_bias
        {
            get { return __pbn__use_bias.GetValueOrDefault(); }
            set { __pbn__use_bias = value; }
        }
        public bool ShouldSerializeuse_bias()
        {
            return __pbn__use_bias != null;
        }
        public void Resetuse_bias()
        {
            __pbn__use_bias = null;
        }
        private bool? __pbn__use_bias;

        [global::ProtoBuf.ProtoMember(3)]
        public TensorParameter kernel { get; set; }

        [global::ProtoBuf.ProtoMember(4)]
        public TensorParameter bias { get; set; }

        [global::ProtoBuf.ProtoMember(5)]
        public int stride
        {
            get { return __pbn__stride.GetValueOrDefault(); }
            set { __pbn__stride = value; }
        }
        public bool ShouldSerializestride()
        {
            return __pbn__stride != null;
        }
        public void Resetstride()
        {
            __pbn__stride = null;
        }
        private int? __pbn__stride;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MaxPool1dParameter : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public MaxPool1dParameter()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public int kernel_size
        {
            get { return __pbn__kernel_size.GetValueOrDefault(); }
            set { __pbn__kernel_size = value; }
        }
        public bool ShouldSerializekernel_size()
        {
            return __pbn__kernel_size != null;
        }
        public void Resetkernel_size()
        {
            __pbn__kernel_size = null;
        }
        private int? __pbn__kernel_size;

        [global::ProtoBuf.ProtoMember(2)]
        public int stride
        {
            get { return __pbn__stride.GetValueOrDefault(); }
            set { __pbn__stride = value; }
        }
        public bool ShouldSerializestride()
        {
            return __pbn__stride != null;
        }
        public void Resetstride()
        {
            __pbn__stride = null;
        }
        private int? __pbn__stride;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class AvgPool1dParameter : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public AvgPool1dParameter()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public int kernel_size
        {
            get { return __pbn__kernel_size.GetValueOrDefault(); }
            set { __pbn__kernel_size = value; }
        }
        public bool ShouldSerializekernel_size()
        {
            return __pbn__kernel_size != null;
        }
        public void Resetkernel_size()
        {
            __pbn__kernel_size = null;
        }
        private int? __pbn__kernel_size;

        [global::ProtoBuf.ProtoMember(2)]
        public int stride
        {
            get { return __pbn__stride.GetValueOrDefault(); }
            set { __pbn__stride = value; }
        }
        public bool ShouldSerializestride()
        {
            return __pbn__stride != null;
        }
        public void Resetstride()
        {
            __pbn__stride = null;
        }
        private int? __pbn__stride;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class BatchNormalizationParameter : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public BatchNormalizationParameter()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(1e-005)]
        public double epsilon
        {
            get { return __pbn__epsilon ?? 1e-005; }
            set { __pbn__epsilon = value; }
        }
        public bool ShouldSerializeepsilon()
        {
            return __pbn__epsilon != null;
        }
        public void Resetepsilon()
        {
            __pbn__epsilon = null;
        }
        private double? __pbn__epsilon;

        [global::ProtoBuf.ProtoMember(2)]
        public int axis
        {
            get { return __pbn__axis.GetValueOrDefault(); }
            set { __pbn__axis = value; }
        }
        public bool ShouldSerializeaxis()
        {
            return __pbn__axis != null;
        }
        public void Resetaxis()
        {
            __pbn__axis = null;
        }
        private int? __pbn__axis;

        [global::ProtoBuf.ProtoMember(3)]
        public bool center
        {
            get { return __pbn__center.GetValueOrDefault(); }
            set { __pbn__center = value; }
        }
        public bool ShouldSerializecenter()
        {
            return __pbn__center != null;
        }
        public void Resetcenter()
        {
            __pbn__center = null;
        }
        private bool? __pbn__center;

        [global::ProtoBuf.ProtoMember(4)]
        public bool scale
        {
            get { return __pbn__scale.GetValueOrDefault(); }
            set { __pbn__scale = value; }
        }
        public bool ShouldSerializescale()
        {
            return __pbn__scale != null;
        }
        public void Resetscale()
        {
            __pbn__scale = null;
        }
        private bool? __pbn__scale;

        [global::ProtoBuf.ProtoMember(5)]
        public float momentum
        {
            get { return __pbn__momentum.GetValueOrDefault(); }
            set { __pbn__momentum = value; }
        }
        public bool ShouldSerializemomentum()
        {
            return __pbn__momentum != null;
        }
        public void Resetmomentum()
        {
            __pbn__momentum = null;
        }
        private float? __pbn__momentum;

        [global::ProtoBuf.ProtoMember(6)]
        public TensorParameter mu { get; set; }

        [global::ProtoBuf.ProtoMember(7)]
        public TensorParameter sigma { get; set; }

        [global::ProtoBuf.ProtoMember(8)]
        public TensorParameter gamma { get; set; }

        [global::ProtoBuf.ProtoMember(9)]
        public TensorParameter beta { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class LSTMParameter : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public LSTMParameter()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public int units
        {
            get { return __pbn__units.GetValueOrDefault(); }
            set { __pbn__units = value; }
        }
        public bool ShouldSerializeunits()
        {
            return __pbn__units != null;
        }
        public void Resetunits()
        {
            __pbn__units = null;
        }
        private int? __pbn__units;

        [global::ProtoBuf.ProtoMember(2)]
        public bool return_sequences
        {
            get { return __pbn__return_sequences.GetValueOrDefault(); }
            set { __pbn__return_sequences = value; }
        }
        public bool ShouldSerializereturn_sequences()
        {
            return __pbn__return_sequences != null;
        }
        public void Resetreturn_sequences()
        {
            __pbn__return_sequences = null;
        }
        private bool? __pbn__return_sequences;

        [global::ProtoBuf.ProtoMember(3)]
        public bool stateful
        {
            get { return __pbn__stateful.GetValueOrDefault(); }
            set { __pbn__stateful = value; }
        }
        public bool ShouldSerializestateful()
        {
            return __pbn__stateful != null;
        }
        public void Resetstateful()
        {
            __pbn__stateful = null;
        }
        private bool? __pbn__stateful;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue("")]
        public string activation
        {
            get { return __pbn__activation ?? ""; }
            set { __pbn__activation = value; }
        }
        public bool ShouldSerializeactivation()
        {
            return __pbn__activation != null;
        }
        public void Resetactivation()
        {
            __pbn__activation = null;
        }
        private string __pbn__activation;

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue("")]
        public string recurrent_activation
        {
            get { return __pbn__recurrent_activation ?? ""; }
            set { __pbn__recurrent_activation = value; }
        }
        public bool ShouldSerializerecurrent_activation()
        {
            return __pbn__recurrent_activation != null;
        }
        public void Resetrecurrent_activation()
        {
            __pbn__recurrent_activation = null;
        }
        private string __pbn__recurrent_activation;

        [global::ProtoBuf.ProtoMember(6)]
        public bool use_bias
        {
            get { return __pbn__use_bias.GetValueOrDefault(); }
            set { __pbn__use_bias = value; }
        }
        public bool ShouldSerializeuse_bias()
        {
            return __pbn__use_bias != null;
        }
        public void Resetuse_bias()
        {
            __pbn__use_bias = null;
        }
        private bool? __pbn__use_bias;

        [global::ProtoBuf.ProtoMember(7)]
        [global::System.ComponentModel.DefaultValue(true)]
        public bool unit_forget_bias
        {
            get { return __pbn__unit_forget_bias ?? true; }
            set { __pbn__unit_forget_bias = value; }
        }
        public bool ShouldSerializeunit_forget_bias()
        {
            return __pbn__unit_forget_bias != null;
        }
        public void Resetunit_forget_bias()
        {
            __pbn__unit_forget_bias = null;
        }
        private bool? __pbn__unit_forget_bias;

        [global::ProtoBuf.ProtoMember(8)]
        [global::System.ComponentModel.DefaultValue(false)]
        public bool go_backwards
        {
            get { return __pbn__go_backwards ?? false; }
            set { __pbn__go_backwards = value; }
        }
        public bool ShouldSerializego_backwards()
        {
            return __pbn__go_backwards != null;
        }
        public void Resetgo_backwards()
        {
            __pbn__go_backwards = null;
        }
        private bool? __pbn__go_backwards;

        [global::ProtoBuf.ProtoMember(9)]
        [global::System.ComponentModel.DefaultValue(false)]
        public bool unroll
        {
            get { return __pbn__unroll ?? false; }
            set { __pbn__unroll = value; }
        }
        public bool ShouldSerializeunroll()
        {
            return __pbn__unroll != null;
        }
        public void Resetunroll()
        {
            __pbn__unroll = null;
        }
        private bool? __pbn__unroll;

        [global::ProtoBuf.ProtoMember(10)]
        [global::System.ComponentModel.DefaultValue(0)]
        public int implementation
        {
            get { return __pbn__implementation ?? 0; }
            set { __pbn__implementation = value; }
        }
        public bool ShouldSerializeimplementation()
        {
            return __pbn__implementation != null;
        }
        public void Resetimplementation()
        {
            __pbn__implementation = null;
        }
        private int? __pbn__implementation;

        [global::ProtoBuf.ProtoMember(15)]
        public TensorParameter weights_input { get; set; }

        [global::ProtoBuf.ProtoMember(16)]
        public TensorParameter weights_forget { get; set; }

        [global::ProtoBuf.ProtoMember(17)]
        public TensorParameter weights_cell { get; set; }

        [global::ProtoBuf.ProtoMember(18)]
        public TensorParameter weights_output { get; set; }

        [global::ProtoBuf.ProtoMember(19)]
        public TensorParameter bias_input { get; set; }

        [global::ProtoBuf.ProtoMember(20)]
        public TensorParameter bias_forget { get; set; }

        [global::ProtoBuf.ProtoMember(21)]
        public TensorParameter bias_cell { get; set; }

        [global::ProtoBuf.ProtoMember(22)]
        public TensorParameter bias_output { get; set; }

        [global::ProtoBuf.ProtoMember(25)]
        public TensorParameter recurrent_weights_input { get; set; }

        [global::ProtoBuf.ProtoMember(26)]
        public TensorParameter recurrent_weights_forget { get; set; }

        [global::ProtoBuf.ProtoMember(27)]
        public TensorParameter recurrent_weights_cell { get; set; }

        [global::ProtoBuf.ProtoMember(28)]
        public TensorParameter recurrent_weights_output { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ActivationParameter : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public ActivationParameter()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string activation
        {
            get { return __pbn__activation ?? ""; }
            set { __pbn__activation = value; }
        }
        public bool ShouldSerializeactivation()
        {
            return __pbn__activation != null;
        }
        public void Resetactivation()
        {
            __pbn__activation = null;
        }
        private string __pbn__activation;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class FlattenParameter : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public FlattenParameter()
        {
            OnConstructor();
        }

        partial void OnConstructor();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ConcatenateParameter : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public ConcatenateParameter()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public int axis
        {
            get { return __pbn__axis.GetValueOrDefault(); }
            set { __pbn__axis = value; }
        }
        public bool ShouldSerializeaxis()
        {
            return __pbn__axis != null;
        }
        public void Resetaxis()
        {
            __pbn__axis = null;
        }
        private int? __pbn__axis;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class LayerParameter : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public LayerParameter()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string type
        {
            get { return __pbn__type ?? ""; }
            set { __pbn__type = value; }
        }
        public bool ShouldSerializetype()
        {
            return __pbn__type != null;
        }
        public void Resettype()
        {
            __pbn__type = null;
        }
        private string __pbn__type;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string name
        {
            get { return __pbn__name ?? ""; }
            set { __pbn__name = value; }
        }
        public bool ShouldSerializename()
        {
            return __pbn__name != null;
        }
        public void Resetname()
        {
            __pbn__name = null;
        }
        private string __pbn__name;

        [global::ProtoBuf.ProtoMember(3)]
        public int order_number
        {
            get { return __pbn__order_number.GetValueOrDefault(); }
            set { __pbn__order_number = value; }
        }
        public bool ShouldSerializeorder_number()
        {
            return __pbn__order_number != null;
        }
        public void Resetorder_number()
        {
            __pbn__order_number = null;
        }
        private int? __pbn__order_number;

        [global::ProtoBuf.ProtoMember(4)]
        public InputParameter input
        {
            get { return __pbn__oneof_layers.Is(4) ? ((InputParameter)__pbn__oneof_layers.Object) : default(InputParameter); }
            set { __pbn__oneof_layers = new global::ProtoBuf.DiscriminatedUnionObject(4, value); }
        }
        public bool ShouldSerializeinput()
        {
            return __pbn__oneof_layers.Is(4);
        }
        public void Resetinput()
        {
            global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__oneof_layers, 4);
        }

        private global::ProtoBuf.DiscriminatedUnionObject __pbn__oneof_layers;

        [global::ProtoBuf.ProtoMember(5)]
        public ActivationParameter activation
        {
            get { return __pbn__oneof_layers.Is(5) ? ((ActivationParameter)__pbn__oneof_layers.Object) : default(ActivationParameter); }
            set { __pbn__oneof_layers = new global::ProtoBuf.DiscriminatedUnionObject(5, value); }
        }
        public bool ShouldSerializeactivation()
        {
            return __pbn__oneof_layers.Is(5);
        }
        public void Resetactivation()
        {
            global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__oneof_layers, 5);
        }

        [global::ProtoBuf.ProtoMember(6)]
        public DenseParameter dense
        {
            get { return __pbn__oneof_layers.Is(6) ? ((DenseParameter)__pbn__oneof_layers.Object) : default(DenseParameter); }
            set { __pbn__oneof_layers = new global::ProtoBuf.DiscriminatedUnionObject(6, value); }
        }
        public bool ShouldSerializedense()
        {
            return __pbn__oneof_layers.Is(6);
        }
        public void Resetdense()
        {
            global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__oneof_layers, 6);
        }

        [global::ProtoBuf.ProtoMember(7)]
        public BatchNormalizationParameter batch_normalization
        {
            get { return __pbn__oneof_layers.Is(7) ? ((BatchNormalizationParameter)__pbn__oneof_layers.Object) : default(BatchNormalizationParameter); }
            set { __pbn__oneof_layers = new global::ProtoBuf.DiscriminatedUnionObject(7, value); }
        }
        public bool ShouldSerializebatch_normalization()
        {
            return __pbn__oneof_layers.Is(7);
        }
        public void Resetbatch_normalization()
        {
            global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__oneof_layers, 7);
        }

        [global::ProtoBuf.ProtoMember(8)]
        public LSTMParameter lstm
        {
            get { return __pbn__oneof_layers.Is(8) ? ((LSTMParameter)__pbn__oneof_layers.Object) : default(LSTMParameter); }
            set { __pbn__oneof_layers = new global::ProtoBuf.DiscriminatedUnionObject(8, value); }
        }
        public bool ShouldSerializelstm()
        {
            return __pbn__oneof_layers.Is(8);
        }
        public void Resetlstm()
        {
            global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__oneof_layers, 8);
        }

        [global::ProtoBuf.ProtoMember(9)]
        public FlattenParameter flatten
        {
            get { return __pbn__oneof_layers.Is(9) ? ((FlattenParameter)__pbn__oneof_layers.Object) : default(FlattenParameter); }
            set { __pbn__oneof_layers = new global::ProtoBuf.DiscriminatedUnionObject(9, value); }
        }
        public bool ShouldSerializeflatten()
        {
            return __pbn__oneof_layers.Is(9);
        }
        public void Resetflatten()
        {
            global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__oneof_layers, 9);
        }

        [global::ProtoBuf.ProtoMember(10)]
        public ConcatenateParameter concatenate
        {
            get { return __pbn__oneof_layers.Is(10) ? ((ConcatenateParameter)__pbn__oneof_layers.Object) : default(ConcatenateParameter); }
            set { __pbn__oneof_layers = new global::ProtoBuf.DiscriminatedUnionObject(10, value); }
        }
        public bool ShouldSerializeconcatenate()
        {
            return __pbn__oneof_layers.Is(10);
        }
        public void Resetconcatenate()
        {
            global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__oneof_layers, 10);
        }

        [global::ProtoBuf.ProtoMember(11)]
        public Conv1dParameter conv1d
        {
            get { return __pbn__oneof_layers.Is(11) ? ((Conv1dParameter)__pbn__oneof_layers.Object) : default(Conv1dParameter); }
            set { __pbn__oneof_layers = new global::ProtoBuf.DiscriminatedUnionObject(11, value); }
        }
        public bool ShouldSerializeconv1d()
        {
            return __pbn__oneof_layers.Is(11);
        }
        public void Resetconv1d()
        {
            global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__oneof_layers, 11);
        }

        [global::ProtoBuf.ProtoMember(12)]
        public MaxPool1dParameter maxpool1d
        {
            get { return __pbn__oneof_layers.Is(12) ? ((MaxPool1dParameter)__pbn__oneof_layers.Object) : default(MaxPool1dParameter); }
            set { __pbn__oneof_layers = new global::ProtoBuf.DiscriminatedUnionObject(12, value); }
        }
        public bool ShouldSerializemaxpool1d()
        {
            return __pbn__oneof_layers.Is(12);
        }
        public void Resetmaxpool1d()
        {
            global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__oneof_layers, 12);
        }

        [global::ProtoBuf.ProtoMember(13)]
        public AvgPool1dParameter avgpool1d
        {
            get { return __pbn__oneof_layers.Is(13) ? ((AvgPool1dParameter)__pbn__oneof_layers.Object) : default(AvgPool1dParameter); }
            set { __pbn__oneof_layers = new global::ProtoBuf.DiscriminatedUnionObject(13, value); }
        }
        public bool ShouldSerializeavgpool1d()
        {
            return __pbn__oneof_layers.Is(13);
        }
        public void Resetavgpool1d()
        {
            global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__oneof_layers, 13);
        }

    }

}

#pragma warning restore 0612, 1591, 3021