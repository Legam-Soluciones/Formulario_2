using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Formulario_2
{ // ========================== Inicio del Namespace ========================== //

	public partial class VentasXcomision : System.Web.UI.Page
	{ // ----------------- Inicio de la Clase ----------------- //
	 
		protected void Page_Load(object sender, EventArgs e)
		{  // ============= Inicio del Load ================ //

			if (!IsPostBack)
			{
				Llenar_Turno();
			}
			
		} // =============  Fin  del Load  ================ // 		
		public void Llenar_Turno()
		{ // =============== Inicio Llenar Turno =============== //

			Obj_DList_Turno.Items.Add("Diurno");
			Obj_DList_Turno.Items.Add("Tarde");
			Obj_DList_Turno.Items.Add("Nocturno");
			Obj_DList_Turno.Items.Add("Mixto");
			Obj_DList_Turno.Items.Insert(0, "Debe Seleccionar un turno.");

		} // ===============  Fin  Llenar  Turno =============== //
		protected void Obj_Button_Executable_Click(object sender, EventArgs e)
		{ // =============== Inicio Llenar Turno =============== //

			Session["s_Nombre"] = Obj_Nombre.Text;
			Session["s_Ventas"] = Obj_Ventas.Text;
			Session["s_Turno"] = Obj_DList_Turno.Text;
			Response.Redirect("VentasXcomision_Frm_2.aspx");

		} // ===============  Fin  Llenar  Turno =============== //

	}  // -----------------  Fin  de la  Clase ----------------- // 

} // ==========================  Fin  del  Namespace ========================== //

