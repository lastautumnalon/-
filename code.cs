         static void ddlis(object obj)
        {
            int js=0;
            Socket ddso = (Socket)obj;
            ddso.Listen(2);

                js++;
                Socket c1 = ddso.Accept();//用户1
            Socket c2 = ddso.Accept();//2
            //object[] data = { c1, c2 };
            Thread ddls2 = new Thread(ddls1);
            ddls2.Start();
            //2个都在线后启动聊天服务
            while (true)
            {//c1 receive c2 send
                
                
                byte[] da = new byte[10000];
                    int length = c1.Receive(da);
                    string cache = Encoding.UTF8.GetString(da, 0, length);
                    c2.Send(Encoding.UTF8.GetBytes(cache));
            }
        }
        static void ddls1()
        {//c2receive c1send

            //while (true)
            //{

            //    byte[] da = new byte[10000];//怎样才能让[判断c1接收消息并且发送到c2]的方法和[判断c2接收消息并且发送到c1]方法同时执行？
            //  int length = c2.Receive(da);
            //string cache = Encoding.UTF8.GetString(da, 0, length);
            //   c1.Send(Encoding.UTF8.GetBytes(cache));

            // }
        }
