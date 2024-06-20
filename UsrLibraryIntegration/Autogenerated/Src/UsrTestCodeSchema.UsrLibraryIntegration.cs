namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrTestCodeSchema

	/// <exclude/>
	public class UsrTestCodeSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrTestCodeSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrTestCodeSchema(UsrTestCodeSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7edb47ea-a7b4-460b-a954-5a1d3f473b56");
			Name = "UsrTestCode";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("86d28de7-555d-4f85-98a2-36747a4254de");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,83,203,110,219,48,16,188,235,43,22,70,15,210,133,254,128,180,5,28,215,72,122,72,129,218,74,123,222,80,235,136,9,67,169,124,212,17,2,255,123,151,162,44,91,174,139,34,188,216,92,206,236,204,62,20,156,50,143,176,233,156,167,151,171,44,156,220,196,55,242,226,214,251,246,44,92,214,150,176,226,128,40,209,61,187,171,44,107,195,131,86,18,164,70,231,224,222,217,146,156,95,54,21,101,111,25,240,25,158,209,117,70,66,228,124,116,222,50,255,51,220,144,95,189,226,75,171,105,17,31,243,20,135,96,117,209,51,19,63,158,228,32,143,118,150,90,145,241,172,214,255,124,2,67,59,56,198,243,162,24,73,71,122,60,243,57,108,200,3,194,3,58,2,172,42,75,108,87,109,161,107,2,212,248,155,160,49,52,97,36,9,113,205,248,197,0,79,114,247,86,229,209,36,215,126,73,193,116,140,146,12,71,219,65,205,205,34,235,46,37,254,66,91,12,218,175,233,87,224,142,221,38,160,88,72,73,173,23,75,77,104,115,150,120,47,145,173,230,209,228,217,20,197,1,118,71,149,194,178,107,233,167,242,245,247,128,90,249,46,189,253,64,29,40,159,97,219,242,188,208,171,198,204,159,92,99,102,197,197,66,77,5,190,38,184,89,149,96,147,145,9,38,106,174,201,181,141,113,116,23,123,241,72,140,75,119,110,35,238,80,29,134,40,120,15,210,2,92,110,234,178,38,249,220,139,141,9,156,71,31,28,200,184,101,167,104,30,103,126,0,137,175,110,19,100,156,195,166,71,199,149,44,38,232,233,130,12,106,107,238,5,207,176,98,49,31,172,233,117,101,99,60,27,253,11,62,44,236,65,241,186,169,186,177,182,209,198,50,145,69,76,188,96,47,145,146,202,61,155,110,60,131,232,105,198,41,104,63,185,145,118,244,159,146,124,109,155,221,248,149,12,59,179,122,141,187,194,19,206,63,204,134,16,108,81,105,170,96,199,107,113,218,95,120,27,43,57,246,113,63,43,254,101,43,253,219,103,251,63,191,141,230,191,91,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7edb47ea-a7b4-460b-a954-5a1d3f473b56"));
		}

		#endregion

	}

	#endregion

}

