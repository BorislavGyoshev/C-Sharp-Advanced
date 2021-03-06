﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace P9_HTTPServer
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Enter port:");
            var listener = new TcpListener(int.Parse(Console.ReadLine()));
            listener.Start();

            while (true)
            {
                Console.WriteLine("Waiting for connection");
                TcpClient client = listener.AcceptTcpClient();

                using (var sr = new StreamReader(client.GetStream()))
                {
                    using (var sw = new StreamWriter(client.GetStream()))
                    {
                        try
                        {
                            string request = sr.ReadLine();
                            Console.WriteLine(request);
                            string[] tokens = request.Split(' ');
                            string page = tokens[1];

                            if (page == "/")
                            {
                                page = "index.html";
                            }
                            else if (File.Exists("../../" + tokens[1]))
                            {
                                page = tokens[1];
                            }
                            else
                            {
                                page = "error.html";
                            }

                            using (var file = new StreamReader("../../" + page))
                            {
                                sw.WriteLine("HTTP/1.0 200 OK\n");

                                string data = file.ReadLine();

                                while (data != null)
                                {
                                    sw.WriteLine(data);
                                    sw.Flush();
                                    data = file.ReadLine();
                                }

                            }
                        }
                        catch (Exception e)
                        {

                        }
                    }
                }

                client.Close();
            }
        }
    }
}
