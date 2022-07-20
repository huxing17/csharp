//引用变量和实例的关系

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassAndInstance
{
    class Program
    {
        static void Main(string[] args)
        {
            //引用变量为“孩子”，实例为“气球”

            //一、气球没有孩子牵着
            /*new Form();*/

            //二、孩子没有牵着气球
            /*Form myForm;*/

            //三、一个孩子牵着一个气球
            /*Form myForm;            
            myForm = new Form();
            myForm.Text = "My Form";
            myForm.ShowDialog();*/

            //四、多个孩子用各自的绳子牵着一个气球
            Form myForm1;
            Form myForm2;
            myForm1 = new Form();
            myForm2 = myForm1;
            myForm1.Text = "My Form";
            myForm2.Text = "I Change It";
            myForm1.ShowDialog();

            //五、多个孩子用一根绳子牵着气球（暂无）
        }
    }
}
