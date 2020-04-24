using System;
using System.Web;
using System.Web.UI;

namespace Room_Calc
{

    public partial class Default : System.Web.UI.Page
    {
        public void button1Clicked(object sender, EventArgs args)
        {
            IRoomSetResponse manager = new RoomSet();
            Room room = new Room();
            room.width = float.Parse(id_length.Value);
            room.length = float.Parse(id_width.Value);
            room.type = id_material.Value;
            room.tPrice = float.Parse(id_material_cost.Value);
            room.color = id_color.Value;
            room.colorPrice = float.Parse(id_color_cost.Value);
            room.employees = int.Parse(id_employees.Value);
            room.empSalary = float.Parse(id_salary.Value);
            Response.Redirect(manager.GetRoom(room));
        }
    }
}
