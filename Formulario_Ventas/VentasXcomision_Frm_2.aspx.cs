using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Formulario_2
{// ========================== Inicio del Namespace ========================== //
	public partial class VentasXcomision_Frm_2 : System.Web.UI.Page
	{ // ----------------- Inicio de la Clase ----------------- //
		protected void Page_Load(object sender, EventArgs e)
		{ // ============= Inicio del Load ================ //

			Obj_Nombre.Text = "Bienvenido:   " + Session["s_Nombre"];
			Obj_Comision.Text = "Su Comision es:   " +  Calculo_Comision_Turno(Session["s_Turno"].ToString(), Convert.ToDouble(Session["s_Ventas"]));
			Obj_Turno.Text = "Su Turno es:   " + Session["s_Turno"];
		
		} // =============  Fin  del Load  ================ // 	

		// ############# Inicio del Calculo de la Comision ############# //

		double Calculo_Comision_Turno(string p_Turno, double p_Venta)
		{
			double var_Comision;

			if (p_Turno == "Nocturno")
			{
				var_Comision = p_Venta * 0.19;
			}
			else
			{
				var_Comision = p_Venta * 0.02;
			}

			return (var_Comision);
		}

		// #############  Fin  del  Calculo de la Comision ############# //

	} // -----------------  Fin  de la  Clase ----------------- //

} // ==========================  Fin  del  Namespace ========================== //