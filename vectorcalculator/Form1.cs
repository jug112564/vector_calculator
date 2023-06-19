using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vectorcalculator.vector;

namespace vectorcalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void vec2LengthButton_Click(object sender, EventArgs e)
        {
            try
            {
                Vector2 v1 = new Vector2(double.Parse(firstVec2XBox.Text), double.Parse(firstVec2YBox.Text));
                double result = v1.Length();
                resultVec2XBox.Text = result.ToString();
                resultVec2YBox.Text = "";
            }
            catch(FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
        }

        private void vec2LengthSqButton_Click(object sender, EventArgs e)
        {
            try
            {
                Vector2 v1 = new Vector2(double.Parse(firstVec2XBox.Text), double.Parse(firstVec2YBox.Text));
                double result = v1.LengthSq();
                resultVec2XBox.Text = result.ToString();
                resultVec2YBox.Text = "";
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
        }

        private void vec2NormalizeButton_Click(object sender, EventArgs e)
        {
            try
            {
                Vector2 v1 = new Vector2(double.Parse(firstVec2XBox.Text), double.Parse(firstVec2YBox.Text));
                Vector2 result = v1.Normalize();
                resultVec2XBox.Text = result.GetX().ToString();
                resultVec2YBox.Text = result.GetY().ToString(); 
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
        }

        private void vec2PerpButton_Click(object sender, EventArgs e)
        {
            try
            {
                Vector2 v1 = new Vector2(double.Parse(firstVec2XBox.Text), double.Parse(firstVec2YBox.Text));
                Vector2 result = v1.Perp();
                resultVec2XBox.Text = result.GetX().ToString();
                resultVec2YBox.Text = result.GetY().ToString();
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
        }

        private void vec2TruncateButton_Click(object sender, EventArgs e)
        {
            try
            {
                Vector2 v1 = new Vector2(double.Parse(firstVec2XBox.Text), double.Parse(firstVec2YBox.Text));
                Vector2 result = v1.Truncate(double.Parse(vec2Max.Text));
                resultVec2XBox.Text = result.GetX().ToString();
                resultVec2YBox.Text = result.GetY().ToString();
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
        }

        private void vec2GetReverseButton_Click(object sender, EventArgs e)
        {
            try
            {
                Vector2 v1 = new Vector2(double.Parse(firstVec2XBox.Text), double.Parse(firstVec2YBox.Text));
                Vector2 result = v1.GetReverse();
                resultVec2XBox.Text = result.GetX().ToString();
                resultVec2YBox.Text = result.GetY().ToString();
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
        }

        private void vec2DotButton_Click(object sender, EventArgs e)
        {
            try
            {
                Vector2 v1 = new Vector2(double.Parse(firstVec2XBox.Text), double.Parse(firstVec2YBox.Text));
                Vector2 v2 = new Vector2(double.Parse(secondVec2XBox.Text), double.Parse(secondVec2YBox.Text));
                double result = v1.Dot(v2);
                resultVec2XBox.Text = result.ToString();
                resultVec2YBox.Text = "";
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
        }

        private void vec2SignButton_Click(object sender, EventArgs e)
        {
            try
            {
                Vector2 v1 = new Vector2(double.Parse(firstVec2XBox.Text), double.Parse(firstVec2YBox.Text));
                Vector2 v2 = new Vector2(double.Parse(secondVec2XBox.Text), double.Parse(secondVec2YBox.Text));
                int result = v1.Sign(v2);
                resultVec2XBox.Text = result.ToString();
                resultVec2YBox.Text = "";
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
        }

        private void vec2DistanceButton_Click(object sender, EventArgs e)
        {
            try
            {
                Vector2 v1 = new Vector2(double.Parse(firstVec2XBox.Text), double.Parse(firstVec2YBox.Text));
                Vector2 v2 = new Vector2(double.Parse(secondVec2XBox.Text), double.Parse(secondVec2YBox.Text));
                double result = v1.Distance(v2);
                resultVec2XBox.Text = result.ToString();
                resultVec2YBox.Text = "";
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
        }

        private void vec2DistanceSqButton_Click(object sender, EventArgs e)
        {
            try
            {
                Vector2 v1 = new Vector2(double.Parse(firstVec2XBox.Text), double.Parse(firstVec2YBox.Text));
                Vector2 v2 = new Vector2(double.Parse(secondVec2XBox.Text), double.Parse(secondVec2YBox.Text));
                double result = v1.DistanceSq(v2);
                resultVec2XBox.Text = result.ToString();
                resultVec2YBox.Text = "";
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
        }

        private void vec2ReflectButton_Click(object sender, EventArgs e)
        {
            try
            {
                Vector2 v1 = new Vector2(double.Parse(firstVec2XBox.Text), double.Parse(firstVec2YBox.Text));
                Vector2 v2 = new Vector2(double.Parse(secondVec2XBox.Text), double.Parse(secondVec2YBox.Text));
                Vector2 result = v1.Reflect(v2);
                resultVec2XBox.Text = result.GetX().ToString();
                resultVec2YBox.Text = result.GetY().ToString();
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
        }

        private void vec2PlusButton_Click(object sender, EventArgs e)
        {
            try
            {
                Vector2 v1 = new Vector2(double.Parse(firstVec2XBox.Text), double.Parse(firstVec2YBox.Text));
                Vector2 v2 = new Vector2(double.Parse(secondVec2XBox.Text), double.Parse(secondVec2YBox.Text));
                Vector2 result = v1 + v2;
                resultVec2XBox.Text = result.GetX().ToString();
                resultVec2YBox.Text = result.GetY().ToString();
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
        }

        private void vec2MinusButton_Click(object sender, EventArgs e)
        {
            try
            {
                Vector2 v1 = new Vector2(double.Parse(firstVec2XBox.Text), double.Parse(firstVec2YBox.Text));
                Vector2 v2 = new Vector2(double.Parse(secondVec2XBox.Text), double.Parse(secondVec2YBox.Text));
                Vector2 result = v1 - v2;
                resultVec2XBox.Text = result.GetX().ToString();
                resultVec2YBox.Text = result.GetY().ToString();
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
        }

        private void vec2MultipleButton_Click(object sender, EventArgs e)
        {
            try
            {
                Vector2 v1 = new Vector2(double.Parse(firstVec2XBox.Text), double.Parse(firstVec2YBox.Text));
                double v2 = double.Parse(secondVec2XBox.Text);
                Vector2 result = v1 * v2;
                resultVec2XBox.Text = result.GetX().ToString();
                resultVec2YBox.Text = result.GetY().ToString();
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
        }

        private void vec2DivideButton_Click(object sender, EventArgs e)
        {
            try
            {
                Vector2 v1 = new Vector2(double.Parse(firstVec2XBox.Text), double.Parse(firstVec2YBox.Text));
                double v2 = double.Parse(secondVec2XBox.Text);
                Vector2 result = v1 / v2;
                resultVec2XBox.Text = result.GetX().ToString();
                resultVec2YBox.Text = result.GetY().ToString();
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
        }

        private void vec2IsTrueButton_Click(object sender, EventArgs e)
        {
            try
            {
                Vector2 v1 = new Vector2(double.Parse(firstVec2XBox.Text), double.Parse(firstVec2YBox.Text));
                Vector2 v2 = new Vector2(double.Parse(secondVec2XBox.Text), double.Parse(secondVec2YBox.Text));
                bool result = v1 == v2;
                resultVec2XBox.Text = result.ToString();
                resultVec2YBox.Text = "";
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
        }

        private void vec2IsFalseButton_Click(object sender, EventArgs e)
        {
            try
            {
                Vector2 v1 = new Vector2(double.Parse(firstVec2XBox.Text), double.Parse(firstVec2YBox.Text));
                Vector2 v2 = new Vector2(double.Parse(secondVec2XBox.Text), double.Parse(secondVec2YBox.Text));
                bool result = v1 != v2;
                resultVec2XBox.Text = result.ToString();
                resultVec2YBox.Text = "";
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
        }

        private void vec3LengthButton_Click(object sender, EventArgs e)
        {
            try
            {
                Vector3 v1 = new Vector3(double.Parse(firstVec3XBox.Text), double.Parse(firstVec3YBox.Text), double.Parse(firstVec3ZBox.Text));
                double result = v1.Length();
                resultVec3XBox.Text = result.ToString();
                resultVec3YBox.Text = "";
                resultVec3ZBox.Text = "";
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
        }

        private void vec3LengthSqButton_Click(object sender, EventArgs e)
        {
            try
            {
                Vector3 v1 = new Vector3(double.Parse(firstVec3XBox.Text), double.Parse(firstVec3YBox.Text), double.Parse(firstVec3ZBox.Text));
                double result = v1.LengthSq();
                resultVec3XBox.Text = result.ToString();
                resultVec3YBox.Text = "";
                resultVec3ZBox.Text = "";
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
        }

        private void vec3NormalizeButton_Click(object sender, EventArgs e)
        {
            try
            {
                Vector3 v1 = new Vector3(double.Parse(firstVec3XBox.Text), double.Parse(firstVec3YBox.Text), double.Parse(firstVec3ZBox.Text));
                Vector3 result = v1.Normalize();
                resultVec3XBox.Text = result.GetX().ToString();
                resultVec3YBox.Text = result.GetY().ToString();
                resultVec3ZBox.Text = result.GetZ().ToString();
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
        }

        private void vec3PerpButton_Click(object sender, EventArgs e)
        {
            try
            {
                Vector3 v1 = new Vector3(double.Parse(firstVec3XBox.Text), double.Parse(firstVec3YBox.Text), double.Parse(firstVec3ZBox.Text));
                Vector3 result = v1.Perp();
                resultVec3XBox.Text = result.GetX().ToString();
                resultVec3YBox.Text = result.GetY().ToString();
                resultVec3ZBox.Text = result.GetZ().ToString();
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
        }

        private void vec3TruncateButton_Click(object sender, EventArgs e)
        {
            try
            {
                Vector3 v1 = new Vector3(double.Parse(firstVec3XBox.Text), double.Parse(firstVec3YBox.Text), double.Parse(firstVec3ZBox.Text));
                Vector3 result = v1.Truncate(double.Parse(vec3Max.Text));
                resultVec3XBox.Text = result.GetX().ToString();
                resultVec3YBox.Text = result.GetY().ToString();
                resultVec3ZBox.Text = result.GetZ().ToString();
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
        }

        private void vec3GetReverseButton_Click(object sender, EventArgs e)
        {
            try
            {
                Vector3 v1 = new Vector3(double.Parse(firstVec3XBox.Text), double.Parse(firstVec3YBox.Text), double.Parse(firstVec3ZBox.Text));
                Vector3 result = v1.GetReverse();
                resultVec3XBox.Text = result.GetX().ToString();
                resultVec3YBox.Text = result.GetY().ToString();
                resultVec3ZBox.Text = result.GetZ().ToString();
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
        }

        private void vec3DotButton_Click(object sender, EventArgs e)
        {
            try
            {
                Vector3 v1 = new Vector3(double.Parse(firstVec3XBox.Text), double.Parse(firstVec3YBox.Text), double.Parse(firstVec3ZBox.Text));
                Vector3 v2 = new Vector3(double.Parse(secondVec3XBox.Text), double.Parse(secondVec3YBox.Text), double.Parse(secondVec3ZBox.Text));
                double result = v1.Dot(v2);
                resultVec3XBox.Text = result.ToString();
                resultVec3YBox.Text = "";
                resultVec3ZBox.Text = "";
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }

        }

        private void vec3SignButton_Click(object sender, EventArgs e)
        {
            try
            {
                Vector3 v1 = new Vector3(double.Parse(firstVec3XBox.Text), double.Parse(firstVec3YBox.Text), double.Parse(firstVec3ZBox.Text));
                Vector3 v2 = new Vector3(double.Parse(secondVec3XBox.Text), double.Parse(secondVec3YBox.Text), double.Parse(secondVec3ZBox.Text));
                double result = v1.Sign(v2);
                resultVec3XBox.Text = result.ToString();
                resultVec3YBox.Text = "";
                resultVec3ZBox.Text = "";
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
        }

        private void vec3DistanceButton_Click(object sender, EventArgs e)
        {
            try
            {
                Vector3 v1 = new Vector3(double.Parse(firstVec3XBox.Text), double.Parse(firstVec3YBox.Text), double.Parse(firstVec3ZBox.Text));
                Vector3 v2 = new Vector3(double.Parse(secondVec3XBox.Text), double.Parse(secondVec3YBox.Text), double.Parse(secondVec3ZBox.Text));
                double result = v1.Distance(v2);
                resultVec3XBox.Text = result.ToString();
                resultVec3YBox.Text = "";
                resultVec3ZBox.Text = "";
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
        }

        private void vec3DistanceSqButton_Click(object sender, EventArgs e)
        {
            try
            {
                Vector3 v1 = new Vector3(double.Parse(firstVec3XBox.Text), double.Parse(firstVec3YBox.Text), double.Parse(firstVec3ZBox.Text));
                Vector3 v2 = new Vector3(double.Parse(secondVec3XBox.Text), double.Parse(secondVec3YBox.Text), double.Parse(secondVec3ZBox.Text));
                double result = v1.DistanceSq(v2);
                resultVec3XBox.Text = result.ToString();
                resultVec3YBox.Text = "";
                resultVec3ZBox.Text = "";
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
        }

        private void vec3ReflectButton_Click(object sender, EventArgs e)
        {
            try
            {
                Vector3 v1 = new Vector3(double.Parse(firstVec3XBox.Text), double.Parse(firstVec3YBox.Text), double.Parse(firstVec3ZBox.Text));
                Vector3 v2 = new Vector3(double.Parse(secondVec3XBox.Text), double.Parse(secondVec3YBox.Text), double.Parse(secondVec3ZBox.Text));
                Vector3 result = v1.Reflect(v2);
                resultVec3XBox.Text = result.GetX().ToString();
                resultVec3YBox.Text = result.GetY().ToString();
                resultVec3ZBox.Text = result.GetZ().ToString();
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
        }

        private void vec3PlusButton_Click(object sender, EventArgs e)
        {
            try
            {
                Vector3 v1 = new Vector3(double.Parse(firstVec3XBox.Text), double.Parse(firstVec3YBox.Text), double.Parse(firstVec3ZBox.Text));
                Vector3 v2 = new Vector3(double.Parse(secondVec3XBox.Text), double.Parse(secondVec3YBox.Text), double.Parse(secondVec3ZBox.Text));
                Vector3 result = v1 + v2;
                resultVec3XBox.Text = result.GetX().ToString();
                resultVec3YBox.Text = result.GetY().ToString();
                resultVec3ZBox.Text = result.GetZ().ToString();
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
        }

        private void vec3MinusButton_Click(object sender, EventArgs e)
        {
            try
            {
                Vector3 v1 = new Vector3(double.Parse(firstVec3XBox.Text), double.Parse(firstVec3YBox.Text), double.Parse(firstVec3ZBox.Text));
                Vector3 v2 = new Vector3(double.Parse(secondVec3XBox.Text), double.Parse(secondVec3YBox.Text), double.Parse(secondVec3ZBox.Text));
                Vector3 result = v1 - v2;
                resultVec3XBox.Text = result.GetX().ToString();
                resultVec3YBox.Text = result.GetY().ToString();
                resultVec3ZBox.Text = result.GetZ().ToString();
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
        }

        private void vec3MultipleButton_Click(object sender, EventArgs e)
        {
            try
            {
                Vector3 v1 = new Vector3(double.Parse(firstVec3XBox.Text), double.Parse(firstVec3YBox.Text), double.Parse(firstVec3ZBox.Text));
                double v2 = double.Parse(secondVec3XBox.Text);
                Vector3 result = v1 * v2;
                resultVec3XBox.Text = result.GetX().ToString();
                resultVec3YBox.Text = result.GetY().ToString();
                resultVec3ZBox.Text = result.GetZ().ToString();
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
        }

        private void vec3DivideButton_Click(object sender, EventArgs e)
        {
            try
            {
                Vector3 v1 = new Vector3(double.Parse(firstVec3XBox.Text), double.Parse(firstVec3YBox.Text), double.Parse(firstVec3ZBox.Text));
                double v2 = double.Parse(secondVec3XBox.Text);
                Vector3 result = v1 / v2;
                resultVec3XBox.Text = result.GetX().ToString();
                resultVec3YBox.Text = result.GetY().ToString();
                resultVec3ZBox.Text = result.GetZ().ToString();
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
        }

        private void vec3IsTrueButton_Click(object sender, EventArgs e)
        {
            try
            {
                Vector3 v1 = new Vector3(double.Parse(firstVec3XBox.Text), double.Parse(firstVec3YBox.Text), double.Parse(firstVec3ZBox.Text));
                Vector3 v2 = new Vector3(double.Parse(secondVec3XBox.Text), double.Parse(secondVec3YBox.Text), double.Parse(secondVec3ZBox.Text));
                bool result = v1 == v2;
                resultVec3XBox.Text = result.ToString();
                resultVec3YBox.Text = "";
                resultVec3ZBox.Text = "";
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
        }

        private void vec3IsFalseButton_Click(object sender, EventArgs e)
        {
            try
            {
                Vector3 v1 = new Vector3(double.Parse(firstVec3XBox.Text), double.Parse(firstVec3YBox.Text), double.Parse(firstVec3ZBox.Text));
                Vector3 v2 = new Vector3(double.Parse(secondVec3XBox.Text), double.Parse(secondVec3YBox.Text), double.Parse(secondVec3ZBox.Text));
                bool result = v1 != v2;
                resultVec3XBox.Text = result.ToString();
                resultVec3YBox.Text = "";
                resultVec3ZBox.Text = "";
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
        }
    }
}
