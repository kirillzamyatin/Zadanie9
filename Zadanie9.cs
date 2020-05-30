using System;
using System.Collections.Generic;
using studentlib;

namespace zadanie8
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student();
            int g = 0;

            while (g != 6)
            {
                Console.WriteLine("������� �����: \n" +
                    "1-�������� ���������� � ���������\n" +
                    "2-�������� ��������\n" +
                    "3-������� ��������\n" +
                    "4-�������� ��������\n" +
                    "5-����� ���������\n" +
                    "6-�����\n");

                int s = Convert.ToInt32(Console.ReadLine());
                g = s;

                switch (s)
                {
                    case 1:
                        Console.WriteLine("������ �������� ���� �� �������: \n" +
                            "1-��� ���������� � ���������\n" +
                            "2-������ ��������� � ����������\n" +
                            "3-������ ��������� ������ 18\n" +
                            "4-������ ��������� ������ 18\n");

                        int k = Convert.ToInt32(Console.ReadLine());
                        if (k == 1)
                        {
                            Console.Write("������� id ��������: ");
                            string enterId1 = Console.ReadLine();

                            st.ShowStudentById(enterId1);
                        }
                        else if (k == 2)
                        {
                            Console.Write("������� id ��������: ");
                            string enterId2 = Console.ReadLine();

                            st.ShowInitials(enterId2);
                        }
                        else if (k == 3) st.YoungerOlder("a");
                        else if (k == 4) st.YoungerOlder("s");
                        break;
                    case 2:
                        Console.WriteLine("��������������� ������� ������ �������� ��� ���������� \n");
                        Console.Write("id: ");
                        string enterId = Console.ReadLine();
                        Console.Write("���(����� ������): ");
                        string enterFio = Console.ReadLine();
                        Console.Write("���� ��������: ");
                        string enterBirthday = Console.ReadLine();
                        Console.Write("������: ");
                        string enterGroup = Console.ReadLine();

                        st.AddStudent(enterId, enterFio, enterBirthday, enterGroup);
                        break;
                    case 3:
                        Console.Write("������� id ��������, �������� ������ ������� �� ���� ������: ");
                        string enterId3 = Console.ReadLine();

                        st.DelStudent(enterId3);
                        break;
                    case 4:
                        Console.WriteLine("��������������� ������� ������ �������� ��� ��������� \n");
                        Console.Write("id: ");
                        string enterId4 = Console.ReadLine();
                        Console.Write("���(����� ������): ");
                        string enterFio4 = Console.ReadLine();
                        Console.Write("���� ��������: ");
                        string enterBirthday4 = Console.ReadLine();
                        Console.Write("������: ");
                        string enterGroup4 = Console.ReadLine();

                        st.ChangeStudent(enterId4, enterFio4, enterBirthday4, enterGroup4);
                        break;
                    case 5:
                        Console.Write("������� ������� ��������: ");
                        string enterSurname = Console.ReadLine();

                        st.Search(enterSurname);
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}