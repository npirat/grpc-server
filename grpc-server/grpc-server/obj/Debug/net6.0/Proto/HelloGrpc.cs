// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Proto/hello.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981
#region Designer generated code

using grpc = global::Grpc.Core;

namespace eudaimonia.grpc.client.forecast.command {
  public static partial class ForecastCommandService
  {
    static readonly string __ServiceName = "proto.models.ForecastCommandService";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::eudaimonia.grpc.client.forecast.command.ForecastCommand> __Marshaller_proto_models_ForecastCommand = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::eudaimonia.grpc.client.forecast.command.ForecastCommand.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::eudaimonia.grpc.client.forecast.command.Empty> __Marshaller_proto_models_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::eudaimonia.grpc.client.forecast.command.Empty.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::eudaimonia.grpc.client.forecast.command.ForecastCommand, global::eudaimonia.grpc.client.forecast.command.Empty> __Method_HistoryUploadFinishedCommand = new grpc::Method<global::eudaimonia.grpc.client.forecast.command.ForecastCommand, global::eudaimonia.grpc.client.forecast.command.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "HistoryUploadFinishedCommand",
        __Marshaller_proto_models_ForecastCommand,
        __Marshaller_proto_models_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::eudaimonia.grpc.client.forecast.command.HelloReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ForecastCommandService</summary>
    [grpc::BindServiceMethod(typeof(ForecastCommandService), "BindService")]
    public abstract partial class ForecastCommandServiceBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::eudaimonia.grpc.client.forecast.command.Empty> HistoryUploadFinishedCommand(global::eudaimonia.grpc.client.forecast.command.ForecastCommand request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(ForecastCommandServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_HistoryUploadFinishedCommand, serviceImpl.HistoryUploadFinishedCommand).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ForecastCommandServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_HistoryUploadFinishedCommand, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::eudaimonia.grpc.client.forecast.command.ForecastCommand, global::eudaimonia.grpc.client.forecast.command.Empty>(serviceImpl.HistoryUploadFinishedCommand));
    }

  }
}
#endregion
