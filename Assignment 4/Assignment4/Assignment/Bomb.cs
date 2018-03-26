using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Assignment
{
    class Bomb
    {
        static ISet<Object> bomb(int size)
        {
            ISet<Object> root = new HashSet<Object>();
            ISet<Object> s1 = root;
            ISet<Object> s2 = new HashSet<Object>();
            for (int i = 0; i < size; i++)
            {
                ISet<Object> t1 = new HashSet<Object>();
                ISet<Object> t2 = new HashSet<Object>();
                t1.Add("foo"); // Make t1 unequal to t2
                s1.Add(t1);
                s1.Add(t2);
                s2.Add(t1);
                s2.Add(t2);
                s1 = t1;
                s2 = t2;
            }
            return root;
        }

        public static string BinaryFileSerialize(Object obj, string filePath)
        {
            FileStream fileStream = null;
            string errorMsg = null;
            try
            {
                fileStream = new FileStream(filePath, FileMode.Create);
                BinaryFormatter b = new BinaryFormatter();
                b.Serialize(fileStream, obj);
            }
            catch (Exception e)
            {
                errorMsg = e.Message;
            }

            finally
            {
                fileStream?.Close();
            }
            return errorMsg;
        }

        public static T BinaryFileDeSerialize<T> (string filePath, out string errorMessage)
        {
            FileStream fileStream = null;
            errorMessage = null;
            Object obj = null;

            try
            {
                if (!File.Exists(filePath))
                {
                    errorMessage = $"The file {filePath} was not found. ";
                    throw (new FileNotFoundException(errorMessage));
                }

                fileStream = new FileStream(filePath, FileMode.Open);
                BinaryFormatter b = new BinaryFormatter();
                obj = b.Deserialize(fileStream);
            }
            catch (Exception e)
            {
                if (errorMessage != null) // error msg already filled from above
                    errorMessage = e.Message;
            }
            finally
            {
                fileStream?.Close();
            }
            return (T) obj;
        }
    }
}
 