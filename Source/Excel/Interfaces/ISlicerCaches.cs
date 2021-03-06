using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using NetOffice;
namespace NetOffice.ExcelApi
{
	///<summary>
	/// Interface ISlicerCaches 
	/// SupportByVersion Excel, 14,15
	///</summary>
	[SupportByVersionAttribute("Excel", 14,15)]
	[EntityTypeAttribute(EntityType.IsInterface)]
	public class ISlicerCaches : COMObject ,IEnumerable<NetOffice.ExcelApi.SlicerCache>
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(ISlicerCaches);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
		public ISlicerCaches(Core factory, COMObject parentObject, object comProxy) : base(factory, parentObject, comProxy)
		{
			
		}

        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISlicerCaches(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISlicerCaches(Core factory, COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(factory, parentObject, comProxy, comProxyType)
		{

		}

		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISlicerCaches(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		///<param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISlicerCaches(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISlicerCaches() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISlicerCaches(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Excel 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 14,15)]
		public NetOffice.ExcelApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.ExcelApi.Application newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.Application.LateBindingApiWrapperType) as NetOffice.ExcelApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 14,15)]
		public NetOffice.ExcelApi.Enums.XlCreator Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.ExcelApi.Enums.XlCreator)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Excel", 14,15)]
		public object Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 14,15)]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15
		/// Get
		/// </summary>
		/// <param name="index">object Index</param>
		[SupportByVersionAttribute("Excel", 14,15)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.ExcelApi.SlicerCache this[object index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "_Default", paramsArray);
			NetOffice.ExcelApi.SlicerCache newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.SlicerCache.LateBindingApiWrapperType) as NetOffice.ExcelApi.SlicerCache;
			return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Excel 14, 15
		/// 
		/// </summary>
		/// <param name="source">object Source</param>
		/// <param name="sourceField">object SourceField</param>
		/// <param name="name">optional object Name</param>
		[SupportByVersionAttribute("Excel", 14,15)]
		public NetOffice.ExcelApi.SlicerCache Add(object source, object sourceField, object name)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(source, sourceField, name);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.SlicerCache newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.SlicerCache.LateBindingApiWrapperType) as NetOffice.ExcelApi.SlicerCache;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 15
		/// 
		/// </summary>
		/// <param name="source">object Source</param>
		/// <param name="sourceField">object SourceField</param>
		/// <param name="name">optional object Name</param>
		/// <param name="slicerCacheType">optional object SlicerCacheType</param>
		[SupportByVersionAttribute("Excel", 15)]
		public NetOffice.ExcelApi.SlicerCache Add(object source, object sourceField, object name, object slicerCacheType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(source, sourceField, name, slicerCacheType);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.SlicerCache newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.SlicerCache.LateBindingApiWrapperType) as NetOffice.ExcelApi.SlicerCache;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15
		/// 
		/// </summary>
		/// <param name="source">object Source</param>
		/// <param name="sourceField">object SourceField</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 14,15)]
		public NetOffice.ExcelApi.SlicerCache Add(object source, object sourceField)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(source, sourceField);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.SlicerCache newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.SlicerCache.LateBindingApiWrapperType) as NetOffice.ExcelApi.SlicerCache;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 15
		/// 
		/// </summary>
		/// <param name="source">object Source</param>
		/// <param name="sourceField">object SourceField</param>
		/// <param name="name">optional object Name</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[SupportByVersionAttribute("Excel", 15)]
		public NetOffice.ExcelApi.SlicerCache _Add(object source, object sourceField, object name)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(source, sourceField, name);
			object returnItem = Invoker.MethodReturn(this, "_Add", paramsArray);
			NetOffice.ExcelApi.SlicerCache newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.SlicerCache.LateBindingApiWrapperType) as NetOffice.ExcelApi.SlicerCache;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 15
		/// 
		/// </summary>
		/// <param name="source">object Source</param>
		/// <param name="sourceField">object SourceField</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 15)]
		public NetOffice.ExcelApi.SlicerCache _Add(object source, object sourceField)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(source, sourceField);
			object returnItem = Invoker.MethodReturn(this, "_Add", paramsArray);
			NetOffice.ExcelApi.SlicerCache newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.SlicerCache.LateBindingApiWrapperType) as NetOffice.ExcelApi.SlicerCache;
			return newObject;
		}

		#endregion

       #region IEnumerable<NetOffice.ExcelApi.SlicerCache> Member
        
        /// <summary>
		/// SupportByVersionAttribute Excel, 14,15
		/// </summary>
		[SupportByVersionAttribute("Excel", 14,15)]
       public IEnumerator<NetOffice.ExcelApi.SlicerCache> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (NetOffice.ExcelApi.SlicerCache item in innerEnumerator)
               yield return item;
       }

       #endregion
          
		#region IEnumerable Members
       
		/// <summary>
		/// SupportByVersionAttribute Excel, 14,15
		/// </summary>
		[SupportByVersionAttribute("Excel", 14,15)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return NetOffice.Utils.GetProxyEnumeratorAsProperty(this);
		}

		#endregion
		#pragma warning restore
	}
}