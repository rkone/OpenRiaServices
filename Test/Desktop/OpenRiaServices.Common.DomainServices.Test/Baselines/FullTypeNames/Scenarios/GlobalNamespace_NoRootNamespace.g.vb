'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Compare Binary
Option Infer On
Option Strict On
Option Explicit On



'''<summary>
'''Enum GlobalNamespaceTest_Enum_NonShared
'''</summary>
Public Enum GlobalNamespaceTest_Enum_NonShared
    
    '''<summary>
    '''DefaultValue
    '''</summary>
    DefaultValue = 0
    
    '''<summary>
    '''NonDefaultValue
    '''</summary>
    NonDefaultValue = 1
End Enum

Namespace GlobalNamespaceTest
    
    ''' <summary>
    ''' The DomainContext corresponding to the 'GlobalNamespaceTest_DomainService' DomainService.
    ''' </summary>
    <Global.GlobalNamespaceTest_Attribute(EnumProperty:=Global.GlobalNamespaceTest_Enum.NonDefaultValue)>  _
    Partial Public NotInheritable Class GlobalNamespaceTest_DomainContext
        Inherits Global.OpenRiaServices.DomainServices.Client.DomainContext
        
        #Region "Extensibility Method Definitions"

        ''' <summary>
        ''' This method is invoked from the constructor once initialization is complete and
        ''' can be used for further object setup.
        ''' </summary>
        Private Partial Sub OnCreated()
        End Sub

        #End Region
        
        
        ''' <summary>
        ''' Initializes a new instance of the <see cref="GlobalNamespaceTest_DomainContext"/> class.
        ''' </summary>
        Public Sub New()
            Me.New(New Global.System.Uri("GlobalNamespaceTest-GlobalNamespaceTest_DomainService.svc", Global.System.UriKind.Relative))
        End Sub
        
        ''' <summary>
        ''' Initializes a new instance of the <see cref="GlobalNamespaceTest_DomainContext"/> class with the specified service URI.
        ''' </summary>
        ''' <param name="serviceUri">The GlobalNamespaceTest_DomainService service URI.</param>
        Public Sub New(ByVal serviceUri As Global.System.Uri)
            Me.New(Global.OpenRiaServices.DomainServices.Client.DomainContext.CreateDomainClient(GetType(Global.GlobalNamespaceTest.GlobalNamespaceTest_DomainContext.IGlobalNamespaceTest_DomainServiceContract), serviceUri, false))
        End Sub
        
        ''' <summary>
        ''' Initializes a new instance of the <see cref="GlobalNamespaceTest_DomainContext"/> class with the specified <paramref name="domainClient"/>.
        ''' </summary>
        ''' <param name="domainClient">The DomainClient instance to use for this DomainContext.</param>
        Public Sub New(ByVal domainClient As Global.OpenRiaServices.DomainServices.Client.DomainClient)
            MyBase.New(domainClient)
            Me.OnCreated
        End Sub
        
        ''' <summary>
        ''' Gets the set of <see cref="GlobalNamespaceTest_Entity"/> entity instances that have been loaded into this <see cref="GlobalNamespaceTest_DomainContext"/> instance.
        ''' </summary>
        Public ReadOnly Property GlobalNamespaceTest_Entities() As Global.OpenRiaServices.DomainServices.Client.EntitySet(Of Global.GlobalNamespaceTest.GlobalNamespaceTest_Entity)
            Get
                Return MyBase.EntityContainer.GetEntitySet(Of Global.GlobalNamespaceTest.GlobalNamespaceTest_Entity)
            End Get
        End Property
        
        ''' <summary>
        ''' Gets an EntityQuery instance that can be used to load <see cref="GlobalNamespaceTest_Entity"/> entity instances using the 'GetEntities' query.
        ''' </summary>
        ''' <returns>An EntityQuery that can be loaded to retrieve <see cref="GlobalNamespaceTest_Entity"/> entity instances.</returns>
        <Global.GlobalNamespaceTest_Attribute()>  _
        Public Function GetEntitiesQuery() As Global.OpenRiaServices.DomainServices.Client.EntityQuery(Of Global.GlobalNamespaceTest.GlobalNamespaceTest_Entity)
            Me.ValidateMethod("GetEntitiesQuery", Nothing)
            Return MyBase.CreateQuery(Of Global.GlobalNamespaceTest.GlobalNamespaceTest_Entity)("GetEntities", Nothing, false, true)
        End Function
        
        ''' <summary>
        ''' Gets an EntityQuery instance that can be used to load <see cref="GlobalNamespaceTest_Entity"/> entity instances using the 'ReadEntities' query.
        ''' </summary>
        ''' <param name="enumParameter">The value for the 'enumParameter' parameter of the query.</param>
        ''' <returns>An EntityQuery that can be loaded to retrieve <see cref="GlobalNamespaceTest_Entity"/> entity instances.</returns>
        <Global.GlobalNamespaceTest_Attribute()>  _
        Public Function ReadEntitiesQuery(<Global.GlobalNamespaceTest_ValidationAttribute()> ByVal enumParameter As Global.GlobalNamespaceTest_Enum) As Global.OpenRiaServices.DomainServices.Client.EntityQuery(Of Global.GlobalNamespaceTest.GlobalNamespaceTest_Entity)
            Dim parameters As Global.System.Collections.Generic.Dictionary(Of String, Object) = New Global.System.Collections.Generic.Dictionary(Of String, Object)()
            parameters.Add("enumParameter", enumParameter)
            Me.ValidateMethod("ReadEntitiesQuery", parameters)
            Return MyBase.CreateQuery(Of Global.GlobalNamespaceTest.GlobalNamespaceTest_Entity)("ReadEntities", parameters, false, true)
        End Function
        
        ''' <summary>
        ''' Invokes the 'CustomUpdateEntity' method of the specified <see cref="GlobalNamespaceTest_Entity"/> entity.
        ''' </summary>
        ''' <param name="entity">The <see cref="GlobalNamespaceTest_Entity"/> entity instance.</param>
        ''' <param name="enumParameter">The value for the 'enumParameter' parameter for this action.</param>
        Public Sub CustomUpdateEntity(ByVal entity As Global.GlobalNamespaceTest.GlobalNamespaceTest_Entity, ByVal enumParameter As Global.GlobalNamespaceTest_Enum)
            entity.CustomUpdateEntity(enumParameter)
        End Sub
        
        ''' <summary>
        ''' Asynchronously invokes the 'InvokeReturn' method of the DomainService.
        ''' </summary>
        ''' <param name="enumParameter">The value for the 'enumParameter' parameter of this action.</param>
        ''' <param name="callback">Callback to invoke when the operation completes.</param>
        ''' <param name="userState">Value to pass to the callback.  It can be <c>null</c>.</param>
        ''' <returns>An operation instance that can be used to manage the asynchronous request.</returns>
        <Global.GlobalNamespaceTest_Attribute()>  _
        Public Overloads Function InvokeReturn(<Global.GlobalNamespaceTest_ValidationAttribute()> ByVal enumParameter As Global.GlobalNamespaceTest_Enum, ByVal callback As Global.System.Action(Of Global.OpenRiaServices.DomainServices.Client.InvokeOperation(Of Global.GlobalNamespaceTest_Enum)), ByVal userState As Object) As Global.OpenRiaServices.DomainServices.Client.InvokeOperation(Of Global.GlobalNamespaceTest_Enum)
            Dim parameters As Global.System.Collections.Generic.Dictionary(Of String, Object) = New Global.System.Collections.Generic.Dictionary(Of String, Object)()
            parameters.Add("enumParameter", enumParameter)
            Me.ValidateMethod("InvokeReturn", parameters)
            Return Me.InvokeOperation(Of Global.GlobalNamespaceTest_Enum)("InvokeReturn", GetType(Global.GlobalNamespaceTest_Enum), parameters, true, callback, userState)
        End Function
        
        ''' <summary>
        ''' Asynchronously invokes the 'InvokeReturn' method of the DomainService.
        ''' </summary>
        ''' <param name="enumParameter">The value for the 'enumParameter' parameter of this action.</param>
        ''' <returns>An operation instance that can be used to manage the asynchronous request.</returns>
        <Global.GlobalNamespaceTest_Attribute()>  _
        Public Overloads Function InvokeReturn(<Global.GlobalNamespaceTest_ValidationAttribute()> ByVal enumParameter As Global.GlobalNamespaceTest_Enum) As Global.OpenRiaServices.DomainServices.Client.InvokeOperation(Of Global.GlobalNamespaceTest_Enum)
            Dim parameters As Global.System.Collections.Generic.Dictionary(Of String, Object) = New Global.System.Collections.Generic.Dictionary(Of String, Object)()
            parameters.Add("enumParameter", enumParameter)
            Me.ValidateMethod("InvokeReturn", parameters)
            Return Me.InvokeOperation(Of Global.GlobalNamespaceTest_Enum)("InvokeReturn", GetType(Global.GlobalNamespaceTest_Enum), parameters, true, Nothing, Nothing)
        End Function
        
        ''' <summary>
        ''' Asynchronously invokes the 'InvokeReturn' method of the DomainService.
        ''' </summary>
        ''' <param name="enumParameter">The value for the 'enumParameter' parameter of this action.</param>
        ''' <param name="cancellationToken">A cancellation token that can be used to cancel the work</param>
        ''' <returns>An operation instance that can be used to manage the asynchronous request.</returns>
        <Global.GlobalNamespaceTest_Attribute()>  _
        Public Function InvokeReturnAsync(<Global.GlobalNamespaceTest_ValidationAttribute()> ByVal enumParameter As Global.GlobalNamespaceTest_Enum, Optional ByVal cancellationToken As Global.System.Threading.CancellationToken = Nothing) As Global.System.Threading.Tasks.Task(Of Global.OpenRiaServices.DomainServices.Client.InvokeResult(Of Global.GlobalNamespaceTest_Enum))
            Dim parameters As Global.System.Collections.Generic.Dictionary(Of String, Object) = New Global.System.Collections.Generic.Dictionary(Of String, Object)()
            parameters.Add("enumParameter", enumParameter)
            Me.ValidateMethod("InvokeReturn", parameters)
            Return Me.InvokeOperationAsync(Of Global.GlobalNamespaceTest_Enum)("InvokeReturn", parameters, true, cancellationToken)
        End Function
        
        ''' <summary>
        ''' Asynchronously invokes the 'InvokeVoid' method of the DomainService.
        ''' </summary>
        ''' <param name="enumParameter">The value for the 'enumParameter' parameter of this action.</param>
        ''' <param name="callback">Callback to invoke when the operation completes.</param>
        ''' <param name="userState">Value to pass to the callback.  It can be <c>null</c>.</param>
        ''' <returns>An operation instance that can be used to manage the asynchronous request.</returns>
        <Global.GlobalNamespaceTest_Attribute()>  _
        Public Overloads Function InvokeVoid(<Global.GlobalNamespaceTest_ValidationAttribute()> ByVal enumParameter As Global.GlobalNamespaceTest_Enum, ByVal callback As Global.System.Action(Of Global.OpenRiaServices.DomainServices.Client.InvokeOperation), ByVal userState As Object) As Global.OpenRiaServices.DomainServices.Client.InvokeOperation
            Dim parameters As Global.System.Collections.Generic.Dictionary(Of String, Object) = New Global.System.Collections.Generic.Dictionary(Of String, Object)()
            parameters.Add("enumParameter", enumParameter)
            Me.ValidateMethod("InvokeVoid", parameters)
            Return Me.InvokeOperation("InvokeVoid", GetType(Global.System.Void), parameters, true, callback, userState)
        End Function
        
        ''' <summary>
        ''' Asynchronously invokes the 'InvokeVoid' method of the DomainService.
        ''' </summary>
        ''' <param name="enumParameter">The value for the 'enumParameter' parameter of this action.</param>
        ''' <returns>An operation instance that can be used to manage the asynchronous request.</returns>
        <Global.GlobalNamespaceTest_Attribute()>  _
        Public Overloads Function InvokeVoid(<Global.GlobalNamespaceTest_ValidationAttribute()> ByVal enumParameter As Global.GlobalNamespaceTest_Enum) As Global.OpenRiaServices.DomainServices.Client.InvokeOperation
            Dim parameters As Global.System.Collections.Generic.Dictionary(Of String, Object) = New Global.System.Collections.Generic.Dictionary(Of String, Object)()
            parameters.Add("enumParameter", enumParameter)
            Me.ValidateMethod("InvokeVoid", parameters)
            Return Me.InvokeOperation("InvokeVoid", GetType(Global.System.Void), parameters, true, Nothing, Nothing)
        End Function
        
        ''' <summary>
        ''' Asynchronously invokes the 'InvokeVoid' method of the DomainService.
        ''' </summary>
        ''' <param name="enumParameter">The value for the 'enumParameter' parameter of this action.</param>
        ''' <param name="cancellationToken">A cancellation token that can be used to cancel the work</param>
        ''' <returns>An operation instance that can be used to manage the asynchronous request.</returns>
        <Global.GlobalNamespaceTest_Attribute()>  _
        Public Function InvokeVoidAsync(<Global.GlobalNamespaceTest_ValidationAttribute()> ByVal enumParameter As Global.GlobalNamespaceTest_Enum, Optional ByVal cancellationToken As Global.System.Threading.CancellationToken = Nothing) As Global.System.Threading.Tasks.Task(Of Global.OpenRiaServices.DomainServices.Client.InvokeResult)
            Dim parameters As Global.System.Collections.Generic.Dictionary(Of String, Object) = New Global.System.Collections.Generic.Dictionary(Of String, Object)()
            parameters.Add("enumParameter", enumParameter)
            Me.ValidateMethod("InvokeVoid", parameters)
            Return Me.InvokeOperationAsync("InvokeVoid", parameters, true, cancellationToken)
        End Function
        
        ''' <summary>
        ''' Creates a new EntityContainer for this DomainContext's EntitySets.
        ''' </summary>
        ''' <returns>A new container instance.</returns>
        Protected Overrides Function CreateEntityContainer() As Global.OpenRiaServices.DomainServices.Client.EntityContainer
            Return New Global.GlobalNamespaceTest.GlobalNamespaceTest_DomainContext.GlobalNamespaceTest_DomainContextEntityContainer()
        End Function
        
        ''' <summary>
        ''' Service contract for the 'GlobalNamespaceTest_DomainService' DomainService.
        ''' </summary>
        <Global.System.ServiceModel.ServiceContractAttribute(),  _
         Global.System.ServiceModel.ServiceKnownTypeAttribute(GetType(Global.GlobalNamespaceTest_Enum))>  _
        Public Interface IGlobalNamespaceTest_DomainServiceContract
            
            ''' <summary>
            ''' Asynchronously invokes the 'GetEntities' operation.
            ''' </summary>
            ''' <param name="callback">Callback to invoke on completion.</param>
            ''' <param name="asyncState">Optional state object.</param>
            ''' <returns>An IAsyncResult that can be used to monitor the request.</returns>
            <Global.OpenRiaServices.DomainServices.Client.HasSideEffects(false),  _
             Global.System.ServiceModel.OperationContractAttribute(AsyncPattern:=true, Action:="http://tempuri.org/GlobalNamespaceTest_DomainService/GetEntities", ReplyAction:="http://tempuri.org/GlobalNamespaceTest_DomainService/GetEntitiesResponse")>  _
            Function BeginGetEntities(ByVal callback As Global.System.AsyncCallback, ByVal asyncState As Object) As Global.System.IAsyncResult
            
            ''' <summary>
            ''' Completes the asynchronous operation begun by 'BeginGetEntities'.
            ''' </summary>
            ''' <param name="result">The IAsyncResult returned from 'BeginGetEntities'.</param>
            ''' <returns>The 'QueryResult' returned from the 'GetEntities' operation.</returns>
            Function EndGetEntities(ByVal result As Global.System.IAsyncResult) As Global.OpenRiaServices.DomainServices.Client.QueryResult(Of Global.GlobalNamespaceTest.GlobalNamespaceTest_Entity)
            
            ''' <summary>
            ''' Asynchronously invokes the 'InvokeReturn' operation.
            ''' </summary>
            ''' <param name="enumParameter">The value for the 'enumParameter' parameter of this action.</param>
            ''' <param name="callback">Callback to invoke on completion.</param>
            ''' <param name="asyncState">Optional state object.</param>
            ''' <returns>An IAsyncResult that can be used to monitor the request.</returns>
            <Global.OpenRiaServices.DomainServices.Client.HasSideEffects(true),  _
             Global.System.ServiceModel.OperationContractAttribute(AsyncPattern:=true, Action:="http://tempuri.org/GlobalNamespaceTest_DomainService/InvokeReturn", ReplyAction:="http://tempuri.org/GlobalNamespaceTest_DomainService/InvokeReturnResponse")>  _
            Function BeginInvokeReturn(ByVal enumParameter As Global.GlobalNamespaceTest_Enum, ByVal callback As Global.System.AsyncCallback, ByVal asyncState As Object) As Global.System.IAsyncResult
            
            ''' <summary>
            ''' Completes the asynchronous operation begun by 'BeginInvokeReturn'.
            ''' </summary>
            ''' <param name="result">The IAsyncResult returned from 'BeginInvokeReturn'.</param>
            ''' <returns>The 'GlobalNamespaceTest_Enum' returned from the 'InvokeReturn' operation.</returns>
            Function EndInvokeReturn(ByVal result As Global.System.IAsyncResult) As Global.GlobalNamespaceTest_Enum
            
            ''' <summary>
            ''' Asynchronously invokes the 'InvokeVoid' operation.
            ''' </summary>
            ''' <param name="enumParameter">The value for the 'enumParameter' parameter of this action.</param>
            ''' <param name="callback">Callback to invoke on completion.</param>
            ''' <param name="asyncState">Optional state object.</param>
            ''' <returns>An IAsyncResult that can be used to monitor the request.</returns>
            <Global.OpenRiaServices.DomainServices.Client.HasSideEffects(true),  _
             Global.System.ServiceModel.OperationContractAttribute(AsyncPattern:=true, Action:="http://tempuri.org/GlobalNamespaceTest_DomainService/InvokeVoid", ReplyAction:="http://tempuri.org/GlobalNamespaceTest_DomainService/InvokeVoidResponse")>  _
            Function BeginInvokeVoid(ByVal enumParameter As Global.GlobalNamespaceTest_Enum, ByVal callback As Global.System.AsyncCallback, ByVal asyncState As Object) As Global.System.IAsyncResult
            
            ''' <summary>
            ''' Completes the asynchronous operation begun by 'BeginInvokeVoid'.
            ''' </summary>
            ''' <param name="result">The IAsyncResult returned from 'BeginInvokeVoid'.</param>
            Sub EndInvokeVoid(ByVal result As Global.System.IAsyncResult)
            
            ''' <summary>
            ''' Asynchronously invokes the 'ReadEntities' operation.
            ''' </summary>
            ''' <param name="enumParameter">The value for the 'enumParameter' parameter of this action.</param>
            ''' <param name="callback">Callback to invoke on completion.</param>
            ''' <param name="asyncState">Optional state object.</param>
            ''' <returns>An IAsyncResult that can be used to monitor the request.</returns>
            <Global.OpenRiaServices.DomainServices.Client.HasSideEffects(false),  _
             Global.System.ServiceModel.OperationContractAttribute(AsyncPattern:=true, Action:="http://tempuri.org/GlobalNamespaceTest_DomainService/ReadEntities", ReplyAction:="http://tempuri.org/GlobalNamespaceTest_DomainService/ReadEntitiesResponse")>  _
            Function BeginReadEntities(ByVal enumParameter As Global.GlobalNamespaceTest_Enum, ByVal callback As Global.System.AsyncCallback, ByVal asyncState As Object) As Global.System.IAsyncResult
            
            ''' <summary>
            ''' Completes the asynchronous operation begun by 'BeginReadEntities'.
            ''' </summary>
            ''' <param name="result">The IAsyncResult returned from 'BeginReadEntities'.</param>
            ''' <returns>The 'QueryResult' returned from the 'ReadEntities' operation.</returns>
            Function EndReadEntities(ByVal result As Global.System.IAsyncResult) As Global.OpenRiaServices.DomainServices.Client.QueryResult(Of Global.GlobalNamespaceTest.GlobalNamespaceTest_Entity)
            
            ''' <summary>
            ''' Asynchronously invokes the 'SubmitChanges' operation.
            ''' </summary>
            ''' <param name="changeSet">The change-set to submit.</param>
            ''' <param name="callback">Callback to invoke on completion.</param>
            ''' <param name="asyncState">Optional state object.</param>
            ''' <returns>An IAsyncResult that can be used to monitor the request.</returns>
            <Global.System.ServiceModel.OperationContractAttribute(AsyncPattern:=true, Action:="http://tempuri.org/GlobalNamespaceTest_DomainService/SubmitChanges", ReplyAction:="http://tempuri.org/GlobalNamespaceTest_DomainService/SubmitChangesResponse")>  _
            Function BeginSubmitChanges(ByVal changeSet As Global.System.Collections.Generic.IEnumerable(Of Global.OpenRiaServices.DomainServices.Client.ChangeSetEntry), ByVal callback As Global.System.AsyncCallback, ByVal asyncState As Object) As Global.System.IAsyncResult
            
            ''' <summary>
            ''' Completes the asynchronous operation begun by 'BeginSubmitChanges'.
            ''' </summary>
            ''' <param name="result">The IAsyncResult returned from 'BeginSubmitChanges'.</param>
            ''' <returns>The collection of change-set entry elements returned from 'SubmitChanges'.</returns>
            Function EndSubmitChanges(ByVal result As Global.System.IAsyncResult) As Global.System.Collections.Generic.IEnumerable(Of Global.OpenRiaServices.DomainServices.Client.ChangeSetEntry)
        End Interface
        
        Friend NotInheritable Class GlobalNamespaceTest_DomainContextEntityContainer
            Inherits Global.OpenRiaServices.DomainServices.Client.EntityContainer
            
            Public Sub New()
                MyBase.New
                Me.CreateEntitySet(Of Global.GlobalNamespaceTest.GlobalNamespaceTest_Entity)(Global.OpenRiaServices.DomainServices.Client.EntitySetOperations.All)
            End Sub
        End Class
    End Class
    
    ''' <summary>
    ''' The 'GlobalNamespaceTest_Entity' entity class.
    ''' </summary>
    <Global.GlobalNamespaceTest_Attribute(),  _
     Global.GlobalNamespaceTest_ValidationAttribute(),  _
     Global.System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://schemas.datacontract.org/2004/07/GlobalNamespaceTest")>  _
    Partial Public NotInheritable Class GlobalNamespaceTest_Entity
        Inherits Global.OpenRiaServices.DomainServices.Client.Entity
        
        Private _enumProperty As Global.GlobalNamespaceTest_Enum
        
        Private _enumProperty_NonShared As Global.GlobalNamespaceTest_Enum_NonShared
        
        Private _key As Integer
        
        #Region "Extensibility Method Definitions"

        ''' <summary>
        ''' This method is invoked from the constructor once initialization is complete and
        ''' can be used for further object setup.
        ''' </summary>
        Private Partial Sub OnCreated()
        End Sub
        Private Partial Sub OnEnumPropertyChanging(ByVal value As Global.GlobalNamespaceTest_Enum)
        End Sub
        Private Partial Sub OnEnumPropertyChanged()
        End Sub
        Private Partial Sub OnEnumProperty_NonSharedChanging(ByVal value As Global.GlobalNamespaceTest_Enum_NonShared)
        End Sub
        Private Partial Sub OnEnumProperty_NonSharedChanged()
        End Sub
        Private Partial Sub OnKeyChanging(ByVal value As Integer)
        End Sub
        Private Partial Sub OnKeyChanged()
        End Sub
        Private Partial Sub OnCustomUpdateEntityInvoking(ByVal enumParameter As Global.GlobalNamespaceTest_Enum)
        End Sub
        Private Partial Sub OnCustomUpdateEntityInvoked()
        End Sub

        #End Region
        
        
        ''' <summary>
        ''' Initializes a new instance of the <see cref="GlobalNamespaceTest_Entity"/> class.
        ''' </summary>
        Public Sub New()
            MyBase.New
            Me.OnCreated
        End Sub
        
        ''' <summary>
        ''' Gets or sets the 'EnumProperty' value.
        ''' </summary>
        <Global.GlobalNamespaceTest_ValidationAttribute(),  _
         Global.System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property EnumProperty() As Global.GlobalNamespaceTest_Enum
            Get
                Return Me._enumProperty
            End Get
            Set
                If ((Me._enumProperty = value)  _
                            = false) Then
                    Me.OnEnumPropertyChanging(value)
                    Me.RaiseDataMemberChanging("EnumProperty")
                    Me.ValidateProperty("EnumProperty", value)
                    Me._enumProperty = value
                    Me.RaiseDataMemberChanged("EnumProperty")
                    Me.OnEnumPropertyChanged
                End If
            End Set
        End Property
        
        ''' <summary>
        ''' Gets or sets the 'EnumProperty_NonShared' value.
        ''' </summary>
        <Global.GlobalNamespaceTest_ValidationAttribute(),  _
         Global.System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property EnumProperty_NonShared() As Global.GlobalNamespaceTest_Enum_NonShared
            Get
                Return Me._enumProperty_NonShared
            End Get
            Set
                If ((Me._enumProperty_NonShared = value)  _
                            = false) Then
                    Me.OnEnumProperty_NonSharedChanging(value)
                    Me.RaiseDataMemberChanging("EnumProperty_NonShared")
                    Me.ValidateProperty("EnumProperty_NonShared", value)
                    Me._enumProperty_NonShared = value
                    Me.RaiseDataMemberChanged("EnumProperty_NonShared")
                    Me.OnEnumProperty_NonSharedChanged
                End If
            End Set
        End Property
        
        ''' <summary>
        ''' Gets or sets the 'Key' value.
        ''' </summary>
        <Global.GlobalNamespaceTest_ValidationAttribute(),  _
         Global.System.ComponentModel.DataAnnotations.CustomValidationAttribute(GetType(Global.GlobalNamespaceTest_Validation), "Validate"),  _
         Global.System.ComponentModel.DataAnnotations.EditableAttribute(false, AllowInitialValue:=true),  _
         Global.System.ComponentModel.DataAnnotations.KeyAttribute(),  _
         Global.System.ComponentModel.DataAnnotations.RoundtripOriginalAttribute(),  _
         Global.System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Key() As Integer
            Get
                Return Me._key
            End Get
            Set
                If ((Me._key = value)  _
                            = false) Then
                    Me.OnKeyChanging(value)
                    Me.ValidateProperty("Key", value)
                    Me._key = value
                    Me.RaisePropertyChanged("Key")
                    Me.OnKeyChanged
                End If
            End Set
        End Property
        
        ''' <summary>
        ''' Gets a value indicating whether the 'CustomUpdateEntity' action has been invoked on this entity.
        ''' </summary>
        <Global.System.ComponentModel.DataAnnotations.DisplayAttribute(AutoGenerateField:=false)>  _
        Public ReadOnly Property IsCustomUpdateEntityInvoked() As Boolean
            Get
                Return MyBase.IsActionInvoked("CustomUpdateEntity")
            End Get
        End Property
        
        ''' <summary>
        ''' Gets a value indicating whether the 'CustomUpdateEntity' method can be invoked on this entity.
        ''' </summary>
        <Global.System.ComponentModel.DataAnnotations.DisplayAttribute(AutoGenerateField:=false)>  _
        Public ReadOnly Property CanCustomUpdateEntity() As Boolean
            Get
                Return MyBase.CanInvokeAction("CustomUpdateEntity")
            End Get
        End Property
        
        ''' <summary>
        ''' Computes a value from the key fields that uniquely identifies this entity instance.
        ''' </summary>
        ''' <returns>An object instance that uniquely identifies this entity instance.</returns>
        Public Overrides Function GetIdentity() As Object
            Return Me._key
        End Function
        
        ''' <summary>
        ''' Invokes the 'CustomUpdateEntity' action on this entity.
        ''' </summary>
        ''' <param name="enumParameter">The value to pass to the server method's 'enumParameter' parameter.</param>
        <Global.GlobalNamespaceTest_Attribute(),  _
         Global.OpenRiaServices.DomainServices.Client.EntityAction("CustomUpdateEntity", AllowMultipleInvocations:=false)>  _
        Public Sub CustomUpdateEntity(ByVal enumParameter As Global.GlobalNamespaceTest_Enum)
            Me.OnCustomUpdateEntityInvoking(enumParameter)
            MyBase.InvokeAction("CustomUpdateEntity", enumParameter)
            Me.OnCustomUpdateEntityInvoked
        End Sub
    End Class
End Namespace
