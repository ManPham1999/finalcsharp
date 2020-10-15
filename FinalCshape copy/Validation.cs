using System;
using System.Globalization;

namespace FinalCshape
{
    class ValidationCustom<T>
    {
        public static T CheckValid()
        {
            var typeCode = Type.GetTypeCode(typeof(T));
            var i = new object();
            bool flag = false;
            do
            {
                string str = Console.ReadLine();
                flag = true;
                try
                {
                    switch (typeCode)
                    {
                        case TypeCode.String:
                            i = str;
                            break;
                        case TypeCode.Int32:
                            i = Convert.ToInt32(str);
                            if ((int)i <= 0)
                            {
                                Console.WriteLine("Vui lòng nhập lại: ");
                                flag = false;
                            }
                            break;
                        case TypeCode.DateTime:
                            i = DateTime.Parse(str, new CultureInfo("vi-VN"));
                            break;
                        default:
                            i = null;
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Vui lòng nhập lại:");
                    flag = false;
                }

            } while (!flag);

            return (T)i;
        }
    }
}
