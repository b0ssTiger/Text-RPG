

using ConsoleTables;
using System.Numerics;
using System;
using System.Threading;
namespace Text_RPG
{
    //Ctrl + M + O 그룹화 Ctrl + M + L 그룹화 풀기 = 클래스 다이어그램

    internal class Program

    {
        private static Character player;
        private static Inventory inven;
        private static Shop shop;
        private static Shop Eshop;
        public static int rouletteCNT;



        static void Main(string[] args)
        {

            GameDataSetting();
           
            /*
                ██████╗ ███████╗ █████╗ ██╗  ██╗██╗   ██╗    ██████╗ ██╗     ██╗███╗   ██╗██████╗ ███████╗██████╗ ███████╗
                ██╔══██╗██╔════╝██╔══██╗██║ ██╔╝╚██╗ ██╔╝    ██╔══██╗██║     ██║████╗  ██║██╔══██╗██╔════╝██╔══██╗██╔════╝
                ██████╔╝█████╗  ███████║█████╔╝  ╚████╔╝     ██████╔╝██║     ██║██╔██╗ ██║██║  ██║█████╗  ██████╔╝███████╗
                ██╔═══╝ ██╔══╝  ██╔══██║██╔═██╗   ╚██╔╝      ██╔══██╗██║     ██║██║╚██╗██║██║  ██║██╔══╝  ██╔══██╗╚════██║
                ██║     ███████╗██║  ██║██║  ██╗   ██║       ██████╔╝███████╗██║██║ ╚████║██████╔╝███████╗██║  ██║███████║                      
                ╚═╝     ╚══════╝╚═╝  ╚═╝╚═╝  ╚═╝   ╚═╝       ╚═════╝ ╚══════╝╚═╝╚═╝  ╚═══╝╚═════╝ ╚══════╝╚═╝  ╚═╝╚══════╝
            */                                                                                                  

            /* 게임이름 '피키블라인더스'
            영국 드라마 피키블라인더스 에서 영감을 얻었습니다. 
            peaky 절정의,정점 + blinders 다른 것을 고려하지 않는 사람,야단 법석을 떠는 사람 = 물불 가리지 않는 정점의 거친 사람들 이라는 뜻입니다. 
            
            */ 
            //함수별로 정리해 두고 찾아보기 (레고 블럭이라고 생각해서 조립하기)
            //함수화 한다 = 

        }

        static void GameDataSetting()

        {
            ConsoleTable consoleTable = new ConsoleTable(); 


            Console.Clear();//콘솔에 있는 모든 글을 지우는 것 
            Console.Write("         ");
            
            Console.OutputEncoding = System.Text.Encoding.UTF8; //.cs
            Console.WriteLine("            ");
            Console.WriteLine(" ﻿      ┈ ┈ ┈ ⋞ 💠⃟💠⃟💠⃟💠⃟  ⋟ ┈ ┈ ﻿┈ ┈ ⋞ 💠⃟💠⃟💠⃟💠⃟  ⋟ ┈ ┈ ┈ ┈ ⋞ 💠⃟💠⃟💠⃟💠⃟  ⋟ ┈ ┈ ┈ ┈ ⋞ 💠⃟💠⃟💠⃟💠⃟  ⋟ ┈ ┈ ┈    ");
            Console.WriteLine("        ");
            Console.Write("        ");
            Console.WriteLine(" ██████╗ ███████╗ █████╗ ██╗  ██╗██╗   ██╗    ██████╗ ██╗     ██╗███╗   ██╗██████╗ ███████╗██████╗ ███████╗ ");
            Console.Write("        ");
            Console.WriteLine(" ██╔══██╗██╔════╝██╔══██╗██║ ██╔╝╚██╗ ██╔╝    ██╔══██╗██║     ██║████╗  ██║██╔══██╗██╔════╝██╔══██╗██╔════╝");
            Console.Write("        ");
            Console.WriteLine(" ██████╔╝█████╗  ███████║█████╔╝  ╚████╔╝     ██████╔╝██║     ██║██╔██╗ ██║██║  ██║█████╗  ██████╔╝███████╗ ");
            Console.Write("        ");
            Console.WriteLine(" ██╔═══╝ ██╔══╝  ██╔══██║██╔═██╗   ╚██╔╝      ██╔══██╗██║     ██║██║╚██╗██║██║  ██║██╔══╝  ██╔══██╗╚════██║ ");
            Console.Write("        ");
            Console.WriteLine(" ██║     ███████╗██║  ██║██║  ██╗   ██║       ██████╔╝███████╗██║██║ ╚████║██████╔╝███████╗██║  ██║███████║ ");
            Console.Write("        ");
            Console.WriteLine(" ╚═╝     ╚══════╝╚═╝  ╚═╝╚═╝  ╚═╝   ╚═╝       ╚═════╝ ╚══════╝╚═╝╚═╝  ╚═══╝╚═════╝ ╚══════╝╚═╝  ╚═╝╚══════╝ ");
            Console.WriteLine("            ");
            Console.WriteLine(" ﻿      ┈ ┈ ┈ ⋞ 💠⃟💠⃟💠⃟💠⃟  ⋟ ┈ ┈ ﻿┈ ┈ ⋞ 💠⃟💠⃟💠⃟💠⃟  ⋟ ┈ ┈ ┈ ┈ ⋞ 💠⃟💠⃟💠⃟💠⃟  ⋟ ┈ ┈ ┈ ┈ ⋞ 💠⃟💠⃟💠⃟💠⃟  ⋟ ┈ ┈ ┈    ");

            string s = "출력할문자열";
            for (int i = 0; i < s.Length; i++)
            {
                Console.Write(s[i].ToString());
                Thread.Sleep(10);
            }
            // 캐릭터 정보 세팅
            player = new Character("Chad", "조직 보스", 1, 10, 5, 100);
            player.Equitem(new Item("Gun", 20, true, 0, 5, 5));
            player.Equitem(new Item("Cigar", 15, true, 1, 5, 5));
            player.Equitem(new Item("Horse", 500, false, 2, 5, 5));
            inven = new Inventory("가방", 50);
            shop = new Shop(new Item[] { new Item("소주", 3, true, 3 ), new Item("맥주", 4, true, 3), new Item("위스키", 6, true, 3), new Item("말먹이", 10,true, 3) });
            Eshop = new Shop(new Item[] { new Item("소총", 3, true, 0,10,10), new Item("권총", 20, true, 0,25,25)
                , new Item("반지", 10, true, 1, 8, 8), new Item("백마", 500, true, 2) });
            // 술 종류: 소주 맥주 위스키 막걸리
            Console.WriteLine("  ");
            Console.WriteLine();
            Console.Write("                                         ");
            Console.WriteLine(" 버밍엄 마을에 오신 걸 환영합니다.");
            Console.Write("                                         ");
            Console.WriteLine("당신은 셸비 가문의 조직 보스 입니다...");
            Console.WriteLine();
            Console.Write("                                                ");
            Console.WriteLine(" 0 : GAME START");
            Console.Write("                                                ");
            Console.WriteLine(" 1 : EXIT ");

            Console.WriteLine();
            Console.Write("                                            ");
            Console.Write(" 조직을 키우시겠습니까? ");
            if (int.TryParse(Console.ReadLine(), out int input )) 
            {
                if (input == 1) return;
                if (input == 0) DisplayGameIntro();
            }


           

            }

        static void DisplayGameIntro()
        {

            
            Console.Clear();
            Console.WriteLine();
            Console.Write("          ");
            Console.Write("♔∴∵∴♔∴∵∴♔∴∵∴♔∴∵∴♔");
            Console.Write("버밍엄에 오신걸 환영합니다.");
            Console.WriteLine("♔∴∵∴♔∴∵∴♔∴∵∴♔∴∵∴♔");
            Console.WriteLine();
            Console.Write("                            ");
            Console.WriteLine(" ╔═════ °• ♔ •° ═════╗ ");
            Console.WriteLine();
            Console.Write("                    ");
            Console.WriteLine("[            1. 상태보기            ]");
            Console.WriteLine();
            Console.Write("                    ");
            Console.WriteLine("[            2. 인벤토리            ]");
            Console.WriteLine();
            Console.Write("                    ");
            Console.WriteLine("[            3. 상점가기            ]");
            Console.WriteLine();
            Console.Write("                    ");
            Console.WriteLine("[            4. 던전가기            ]");
            Console.WriteLine();
            Console.Write("                    ");
            Console.WriteLine("[            5. 메인화면            ]");
            Console.WriteLine();
            Console.Write("                            ");
            Console.WriteLine(" ╚═════ °• ♔ •° ═════╝ ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요.");

            int input = CheckValidInput(1,5);
            switch (input)
            {
                case 1:
                    DisplayMyInfo();
                    break;

                case 2:
                    DisplayInventory();
                    // 아이템 
                    // 작업해보기
                    break;
                case 3:
                    DisplayRLF();
                    break;

                case 4:
                    rouletteMachine();
                    break;

                case 5:
                    GameDataSetting();
                    break;

            }
        }
        
        static void DisplayMyInfo()
        {
            Console.Clear();

            Console.WriteLine("상태보기");
            Console.WriteLine("캐릭터의 정보를 표시합니다.");
            Console.WriteLine();
            Console.WriteLine($"Lv.{player.Level}"); //이기면 레벨업? 구역관리영역
            Console.WriteLine($"{player.Name}({player.Job})");
            Console.WriteLine($"공격력 :{player.Atk} (+{player.AddAtk})");
            Console.WriteLine($"방어력 : {player.Def} (+{player.AddDef})");
            Console.WriteLine($"체력 : {player.Hp}");
           
            Console.WriteLine();
            Console.WriteLine("0. 나가기");

            int input = CheckValidInput(0, 0);
            switch (input)
            {
                case 0:
                    DisplayGameIntro();
                    break;
            }
        }

        static void DisplayInventory()
        {
            Console.Clear();

            Console.WriteLine("인벤토리");
          
            Console.WriteLine();
            Console.WriteLine($" {inven.Name}");
            Console.WriteLine($"자본{inven.Gold}");
            Console.WriteLine();
            Console.WriteLine($"무기 : {player.Equipment[0].Name}");
            Console.WriteLine($"장식 : {player.Equipment[1].Name}");
            Console.WriteLine($" 말  : {player.Equipment[2].Name}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            //    ConsoleTable Etable = new ConsoleTable("부위","이름");
            //    Etable.AddRow("무기", player.Equipment[0]);
            //    Etable.AddRow("장식", player.Equipment[1]);
            //    Etable.AddRow(" 말 ", player.Equipment[2]);

            //    for (int i = 0; i < Etable.Rows.Count; i++)
            //    {
            //        ConsoleTable
            //.From(Etable.Rows.ToString())
            //.Configure(o => o.NumberAlignment = Alignment.Right)
            //.Write(Format.Alternative);
            //    }

            for (int i = 0; i < inven.Items.Length; i++) // 아이템즈 0~끝번까지 반복해준다. 
            {
                //0. 포션넣기 \
                if (inven.Items[i] == null)
                    continue; // 비어있다면 다음 뻔 아이템 슬롯을 확인해라 ㅇ0ㅇ
                Console.WriteLine(i+"번째 아이템    " + inven.Items[i].Name+"     *" + inven.count[i]); //현재 0번째 ~ i번째 아이템의 이름을 노출시켜라 

            }

            Console.WriteLine();
            Console.WriteLine("6. 나가기");

            int input = CheckValidInput(0, 6);
            switch (input)
            {
                case 6:
                    DisplayGameIntro();
                    break;
            }
            useitem(input);
            DisplayInventory();

        }
        static void useitem(int _int) 
        {
            //아이템을 사용하는 함수 
            if (inven.Items[_int] == null) return;
            if (inven.Items[_int].Kategorie == 3) return;

            inven.Items[_int] = player.Equitem(inven.Items[_int]);
        }
        static void DisplayRLF() 
        {
            Console.Clear();
            Console.WriteLine();
            Console.Write("          ");
            Console.Write("♔∴∵∴♔∴∵∴♔∴∵∴♔∴∵∴♔");
            Console.Write("버밍엄에 오신걸 환영합니다.");
            Console.WriteLine("♔∴∵∴♔∴∵∴♔∴∵∴♔∴∵∴♔");
            Console.WriteLine();
            Console.Write("                            ");
            Console.WriteLine(" ╔═════ °• ♔ •° ═════╗ ");
            Console.WriteLine();
            Console.Write("                    ");
            Console.WriteLine("[            0. 무기상점            ]");
            Console.WriteLine();
            Console.Write("                    ");
            Console.WriteLine("[            1. 주류상점            ]");
            Console.WriteLine();
            Console.Write("                    ");
            Console.WriteLine("[            2. 상점가기            ]");
            Console.WriteLine();
            Console.Write("                            ");
            Console.WriteLine(" ╚═════ °• ♔ •° ═════╝ ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요.");
            // 0번 장비상점 1번 소비상점 2인트로
            int input = CheckValidInput(0, 2);
            switch (input)
            {
                case 0:
                    DisplayEShop();
                    break;
                case 1:
                    DisplayShop();
                    break;
                case 2:
                    DisplayGameIntro();
                    break;
            }

        }
        static void DisplayEShop()
        {
            Console.Clear();

            Console.WriteLine("장비상점");

            Console.WriteLine();
            Console.WriteLine($" {inven.Name}");
            Console.WriteLine($"자본{inven.Gold}");

            for (int i = 0; i < Eshop.Items.Length; i++) // 아이템즈 0~끝번까지 반복해준다. 
            {
                //0. 포션넣기 \
                if (Eshop.Items[i] == null)
                    continue; // 비어있다면 다음 뻔 아이템 슬롯을 확인해라 ㅇ0ㅇ
                //Console.WriteLine(i + "번째 아이템    " + shop.Items[i].Name); //현재 0번째 ~ i번째 아이템의 이름을 노출시켜라 
                Console.WriteLine("{0}번째 아이템    {1}    {2}", i, Eshop.Items[i].Name, Eshop.Items[i].Cash);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("구매"); //번호를 누르면 아이템 사지는거 
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("4. 나가기");

            int input = CheckValidInput(0, 4);

            switch (input)
            {
                case 4:
                    DisplayGameIntro();
                    break;
            }
            if (Eshop.Items[input].Cash > inven.Gold)//내가 가지고 있는 골드 보다 상점아이템이 값이 더 많다면 못사고 
            {
                DisplayEShop(); //상점 화면 그대로 표시
            }
            else //그게 아니라면 
            {
                inven.Gold = inven.Gold - Eshop.Items[input].Cash; // 내 돈에서 아이템가격을 뺀 남는 돈은 다시 내주머니로


                for (int i = 0; i < inven.Items.Length; i++) //내 인벤토리 전체를 탐색해서 
                {
                    if (inven.Items[i] == null) continue;
                    if ((Eshop.Items[input].CountableItem == true) && (Eshop.Items[input].Name == inven.Items[i].Name)) //탐색도중 같은 아이템을 발견한다면
                    {
                        inven.count[i]++; //수량이 하나씩 겹쳐지게 한다. ?문제? 
                        DisplayEShop();
                        return;

                    }



                }
                //겹쳐지는 아이템이지만 내 인벤토리에 똑같은 아이템이 없다면 실행

                //겹쳐지는 아이템이 아니라면 실행
                for (int i = 0; i < inven.Items.Length; i++)// 내 인벤토리 전체를 탐색해서  
                {
                    if (inven.Items[i] == null) // 빈 공간이 발견 된다면  
                    {
                        inven.Items[i] = Eshop.Items[input]; // 그자리에 아이템을 넣어라! 
                        inven.count[i]++; //구매한 횟수 
                        break;
                    }
                }
            }
            DisplayEShop();
        }
        static void DisplayShop()
        {
            Console.Clear();

            Console.WriteLine("상점");

            Console.WriteLine();
            Console.WriteLine($" {inven.Name}");
            Console.WriteLine($"자본{inven.Gold}");

            for (int i = 0; i < shop.Items.Length; i++) // 아이템즈 0~끝번까지 반복해준다. 
            {
                //0. 포션넣기 \
                if (shop.Items[i] == null)
                    continue; // 비어있다면 다음 뻔 아이템 슬롯을 확인해라 ㅇ0ㅇ
                //Console.WriteLine(i + "번째 아이템    " + shop.Items[i].Name); //현재 0번째 ~ i번째 아이템의 이름을 노출시켜라 
                Console.WriteLine( "{0}번째 아이템    {1}    {2}" ,i, shop.Items[i].Name, shop.Items[i].Cash);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("구매"); //번호를 누르면 아이템 사지는거 
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("4. 나가기");

            int input = CheckValidInput(0, 4);

            switch (input)
            { 
                case 4:
                    DisplayGameIntro();
                    break;
            }
            if (shop.Items[input].Cash > inven.Gold)//내가 가지고 있는 골드 보다 상점아이템이 값이 더 많다면 못사고 
            {
                DisplayShop(); //상점 화면 그대로 표시
            }
            else //그게 아니라면 
            {
                inven.Gold = inven.Gold - shop.Items[input].Cash; // 내 돈에서 아이템가격을 뺀 남는 돈은 다시 내주머니로
                
                
                for (int i = 0; i < inven.Items.Length; i++) //내 인벤토리 전체를 탐색해서 
                {
                    if (inven.Items[i] == null) continue;
                    if ((shop.Items[input].CountableItem == true) && (shop.Items[input].Name == inven.Items[i].Name)) //탐색도중 같은 아이템을 발견한다면
                    {
                        inven.count[i]++; //수량이 하나씩 겹쳐지게 한다. ?문제? 
                        DisplayShop();
                        return;

                    }
                    


                }
                //겹쳐지는 아이템이지만 내 인벤토리에 똑같은 아이템이 없다면 실행
                
                //겹쳐지는 아이템이 아니라면 실행
                for (int i = 0; i < inven.Items.Length; i++)// 내 인벤토리 전체를 탐색해서  
                {
                    if (inven.Items[i] == null) // 빈 공간이 발견 된다면  
                    {
                        inven.Items[i] = shop.Items[input]; // 그자리에 아이템을 넣어라! 
                        inven.count[i]++; //구매한 횟수 
                        break;
                    }
                }
            }
            DisplayShop();
        }

        static int CheckValidInput(int min, int max)
        {
            while (true)
            {
                string input = Console.ReadLine(); //ㅇ0ㅇ 오른쪽에서 왼쪽으로 넘어간다!!

                bool parseSuccess = int.TryParse(input, out var ret);
                if (parseSuccess)
                {
                    if (ret >= min && ret <= max)
                        return ret;
                }

                Console.WriteLine("잘못된 입력입니다.");
            }
        }
        public static void rouletteMachine() //룰렛게임 
        {
            string inputData;
            int raiseMoney;
            int returnValue = -1;

            while (true)
            {
                Console.Write("제시하신 금액에 비례하여 보상이 주어집니다.\n얼마를 제시하시겠습니까? ");
                inputData = Console.ReadLine();
                bool inputDataCheck = int.TryParse(inputData, out raiseMoney);

                if (!inputDataCheck) continue;
                break;
            }
            Thread roulette = new Thread(() => returnValue = makeRoulett(raiseMoney));
            Thread rouletteStopBtn = new Thread(() => rouletteBtn());
            roulette.Start();
            rouletteStopBtn.Start();

            while (returnValue == -1)
            {

            }

            switch (returnValue)
            {
                case 0:
                    rouletteMachine();
                    break;
                    //컨트롤 케이 에프 - 전체 줄 맞추어주기 
                case 1:
                    DisplayGameIntro();
                    break;

            }

        }
        public static int makeRoulett(int _inputMoney)
        {
            string rouletteShape = "♠♥⑦♣◆";
            char[,] roulleteLine = new char[3, 3];
            inven.Gold -= _inputMoney;
            Random rand = new Random();
            while (true)
            {
                if (rouletteCNT >= 3) break;
                Console.Clear();
                for (int i = rouletteCNT; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        int temp = rand.Next(0, rouletteShape.Length);
                        roulleteLine[i, j] = rouletteShape[temp];
                    }
                }
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(roulleteLine[j, i] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("정지를 원하시면 enter를 눌러주세요. ");
                Thread.Sleep(200);
            }
            int bonusValue = 0;
            if ((roulleteLine[0, 0] == roulleteLine[1, 0]) && (roulleteLine[0, 0] == roulleteLine[2, 0]))
            {
                bonusValue = setBonus(bonusValue, roulleteLine[0, 0]);
            }
            if ((roulleteLine[0, 0] == roulleteLine[1, 1]) && (roulleteLine[0, 0] == roulleteLine[2, 2]))
            {
                bonusValue = setBonus(bonusValue, roulleteLine[0, 0]);
            }
            if ((roulleteLine[2, 0] == roulleteLine[1, 1]) && (roulleteLine[2, 0] == roulleteLine[0, 2]))
            {
                bonusValue = setBonus(bonusValue, roulleteLine[0, 0]);
            }
            if ((roulleteLine[0, 1] == roulleteLine[1, 1]) && (roulleteLine[0, 1] == roulleteLine[2, 1]))
            {
                bonusValue = setBonus(bonusValue, roulleteLine[0, 0]);
            }
            if ((roulleteLine[0, 2] == roulleteLine[1, 2]) && (roulleteLine[0, 2] == roulleteLine[2, 2]))
            {
                bonusValue = setBonus(bonusValue, roulleteLine[0, 0]);
            }
            inven.Gold += _inputMoney * bonusValue;

            Console.WriteLine(" 다시 하실? ");
            int input = CheckValidInput(0, 1);
            
            return input;
        }
        public static int setBonus(int _bonus, char _shape)
        {
            Console.WriteLine("축하드립니다. ");
            Console.WriteLine(_shape + "무늬에 당첨 되셨습니다.");
            return _bonus;
        }
        public static void rouletteBtn()
        {
            string input = null;
            while (true)
            {
                while (true)
                {
                    input = Console.ReadLine();
                    if (input != null) break;
                }
                rouletteCNT++;
                if (rouletteCNT >= 3) break;
            }
        }

    }

    public class Character
        {
        public string Name { get; }
        public string Job { get; }
        public int Level { get; }
        public int Atk { get; }
        public int Def { get; }
        public int Hp { get; }

        public int AddAtk;

        public int AddDef;

        //양손 무기 장식 말(백마 흑마 말
        public Item[] Equipment = new Item[3]; 
        public Item Equitem(Item item)
        {
            Item temp = null;
            if (Equipment[item.Kategorie] == null)
            {
                Equipment[item.Kategorie] = item;
            }
            else
            {
                temp = Equipment[item.Kategorie];// 내가 끼고있는걸 인벤토리에 넣으려면 잠시 다른 곳으로 이동 *temp
                Equipment[item.Kategorie] = item;
                item = temp; //새로운 임시 변수에 하나를 넣어두고 나머지를 다시 넣어주는 형식 
            }
             AddAtk = AddDef = 0;
            for (int i = 0; i < Equipment.Length; i++) 
            {
                if (Equipment[i] == null) continue;
               // AddAtk = AddAtk + Equipment[i].AddAtk;
                AddAtk += Equipment[i].AddAtk;
                AddDef += Equipment[i].AddDef; //*= -= 


            }
            return temp;
        }


        public Character(string name, string job, int level, int atk, int def, int hp, Item ep0,Item ep1,Item ep2)
        {
            Name = name;
            Job = job;
            Level = level;
            Atk = atk;
            Def = def;
            Hp = hp;
            Equipment[0] = ep0;
            Equipment[1] = ep1;
            Equipment[2] = ep2;
            AddAtk = 0;
            AddDef = 0;
        }
        public Character(string name, string job, int level, int atk, int def, int hp )
        {
            Name = name;
            Job = job;
            Level = level;
            Atk = atk;
            Def = def;
            Hp = hp;
            Equipment[0] = null;
            Equipment[1] = null;
            Equipment[2] = null;
            AddAtk = 0;
            AddDef = 0;
        }
    }
    public class Inventory
    {
        public string Name { get; }
        public int[] count = new int[6]; 
        public int Gold;    //set 값을 넣을때 ger 값을 가지고 올때 사용
        public Item[] Items = new Item[6];  // 아이템 가방 배열사용  [] 
        //가방 비워주기 반복문
        
        public Inventory(string name, int gold)
        {
            Name = name;
            Gold = gold;
            for (int i = 0;  i < Items.Length; i++) 
            {
                Items[i] = null; // 몇번째 값 null 아무것도 없는 값(비어있는값)

            }
            //[] 배열 컴퓨터는 0 부터 순서! 0 ~ 5 
            Items[0] = new Item("potion", 3, true, 3); // 가방 한 공간에는 새로운 아이템 이름 캐쉬 카운트 그럼 ? 포션값은 3 포션의 갯수 
            count[0] = 1;

        }

    }
    public class Item
    {
        public string Name { get; }
        public bool CountableItem { get; } //수량을 셀 수있는 아이템 
        public int Cash { get; }

        public int Kategorie;

        public int AddAtk;

        public int AddDef;

        public Item(string name, int cash, bool count, int kate) 
        {
             Name = name;
             Cash = cash;
             CountableItem = count;
             Kategorie = kate;
             AddAtk = 0;
             AddDef = 0;
        }
        public Item(string name, int cash, bool count, int kate, int atk, int def)
        {
            Name = name;
            Cash = cash;
            CountableItem = count;
            Kategorie = kate;
            AddAtk = atk;
            AddDef = def;
        }
    }
    
}
