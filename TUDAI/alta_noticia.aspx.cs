using System;
using System.Data;
using DAL;

namespace TUDAI
{
    public partial class AltaNoticia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarDdls();
                var id = 0;
                if(int.TryParse(Request.QueryString["id"], out id)){
                    cargarNoticia(id);
                }
            }
            else
                CargarDdls();
        }


        private void cargarNoticia(int id)
        {
            var aux = new Noticia();
            aux.Id = id;
            using(NoticiaBusiness n = new NoticiaBusiness())
            {
                var noticia = n.GetNoticiaById(aux);
                txt_titulo.Text = noticia.Tables[0].Rows[0]["titulo"].ToString();
                txt_cuerpo.Text = noticia.Tables[0].Rows[0]["cuerpo"].ToString();
            }
        }

        private void CargarDdls()
        {
            ddl_categorias.DataSource = new CategoriaBusiness().GetCategorias();
            ddl_categorias.DataBind();
        }

        protected void Handler_Noticia(object sender, EventArgs e)
        {
            var id = 0;
            if (int.TryParse(Request.QueryString["id"], out id))
                Editar_Noticia(sender, e);
            else
                Publicar_Noticia(sender, e);
        }

        protected void Publicar_Noticia(object sender, EventArgs e)
        {
            var oNoticia = new Noticia()
            {
                Titulo = txt_titulo.Text,
                Cuerpo = txt_cuerpo.Text,
                Fecha = date_fecha.SelectedDate,
                IdCategoria = int.Parse(ddl_categorias.SelectedValue)
            };
            new NoticiaBusiness().InsertNoticia(oNoticia);
            
            lbl_resultado.Text = "Noticia publicada correctamente";              
        }

        protected void Editar_Noticia(object sender, EventArgs e)
        {
            var id = 0;
            int.TryParse(Request.QueryString["id"], out id);
            var oNoticia = new Noticia()
            {
                Id = id,
                Titulo = txt_titulo.Text,
                Cuerpo = txt_cuerpo.Text,
                Fecha = date_fecha.SelectedDate,
                IdCategoria = int.Parse(ddl_categorias.SelectedValue)
            };
            new NoticiaBusiness().UpdateNoticia(oNoticia);

            lbl_resultado.Text = "Noticia editada correctamente";

        }
    }
}