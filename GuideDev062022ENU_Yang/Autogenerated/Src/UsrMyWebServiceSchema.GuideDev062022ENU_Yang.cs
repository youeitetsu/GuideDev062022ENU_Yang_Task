namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrMyWebServiceSchema

	/// <exclude/>
	public class UsrMyWebServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrMyWebServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrMyWebServiceSchema(UsrMyWebServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("19eb5230-2b0b-4854-a616-45e6f36424d6");
			Name = "UsrMyWebService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a8e5ac76-2e7d-424f-8dc0-ab0a3fd833af");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,83,208,3,2,0,29,111,12,162,5,0,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("19eb5230-2b0b-4854-a616-45e6f36424d6"));
		}

		#endregion

	}

	#endregion

}

