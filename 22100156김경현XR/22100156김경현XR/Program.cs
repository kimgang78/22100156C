using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wow
{
    class Program
    {
        static double attack, hp, defense, porsiongood, monhp, monattack, monexp, expbox = 0, Criticalhit, Critical;
        static int porsion, level = 0, maxexp = 1, stats, work, skillturn, turn;
        static string monname, name, monambassador;




        static void Main(string[] args)
        {

            Page1();
            Console.WriteLine("");
            EnterKeyWait();


            Console.Clear();
            Console.WriteLine(" 직업 선택 ");
            Console.WriteLine(" 1 : 대충 단단함 ");
            Console.WriteLine(" 2 : 대충 밸런스 맞음 ");
            Console.WriteLine(" 3 : 딜만 쌤 ");
            Console.WriteLine(" 4 : 포션만 많음 ");
            Console.WriteLine("5 : 운에 모든걸 건다");
            string k = "";

            ConsoleKeyInfo key = Console.ReadKey();
            k = key.Key.ToString();
            EnterKeyWait();
            Console.Clear();
            if (k == "D1")
            {
                attack = 10;
                hp = 200;
                defense = 10;
                porsion = 10;
                Criticalhit = 2;
                porsiongood = 50;
                Critical = 20;
                work = 1;
                Console.WriteLine("당신은 전사 입니다. ");
                Console.WriteLine("공격력 : 10 / 체력 : 200 / 방어력 : 10 / 크리티컬 확률 : 20% / 크리티컬 데미지 : 2배 /  포션 : 10 ");
                EnterKeyWait();
            }
            if (k == "D2")
            {
                attack = 20;
                hp = 100;
                defense = 5;
                porsion = 10;
                porsiongood = 50;
                Criticalhit = 2;
                Critical = 20;
                work = 2;
                Console.WriteLine("당신은 궁수 입니다. ");
                Console.WriteLine("공격력 : 20 / 체력 : 100 / 방어력 : 5 / 크리티컬 확률 : 20% / 크리티컬 데미지 : 2배 /  포션 : 10 ");
                EnterKeyWait();
            }
            if (k == "D3")
            {
                attack = 30;
                hp = 75;
                defense = 5;
                porsion = 10;
                porsiongood = 50;
                Criticalhit = 2;
                Critical = 20;
                work = 3;
                Console.WriteLine("당신은 마법사 입니다. ");
                Console.WriteLine("공격력 : 30 / 체력 : 75 / 방어력 : 5 / 크리티컬 확률 : 20% / 크리티컬 데미지 : 2배 /  포션 : 10 ");
                EnterKeyWait();
            }
            if (k == "D4")
            {
                attack = 15;
                hp = 100;
                defense = 7;
                porsion = 50;
                porsiongood = 50;
                Criticalhit = 2;
                Critical = 20;
                work = 4;
                Console.WriteLine("당신은 상인 입니다. ");
                Console.WriteLine("공격력 : 15 / 체력 : 100 / 방어력 : 7 / 크리티컬 확률 : 20% / 크리티컬 데미지 : 2배 / 포션 : 50 ");
                EnterKeyWait();
            }
            if (k == "D5")
            {
                attack = 20;
                hp = 100;
                defense = 5;
                porsion = 10;
                porsiongood = 50;
                Criticalhit = 5;
                Critical = 10;
                work = 5;
                Console.WriteLine("당신은 도박사 입니다. ");
                Console.WriteLine("공격력 : 20 / 체력 : 100 / 방어력 : 5 / 크리티컬 확률 : 10% / 크리티컬 데미지 : 5배 / 포션 : 10 ");
                EnterKeyWait();
            }


            Page2();


            EnterKeyWait();
            monname = "박쥐";
            mon();
            battle();

            Console.WriteLine("");
            EnterKeyWait();
            monname = "돼지박쥐";
            mon();
            battle();
            Console.WriteLine("");
            EnterKeyWait();
            monname = "멧돼지";
            mon();
            battle();

            Console.WriteLine("");
            EnterKeyWait();
            monname = "뿔멧돼지";
            mon();
            battle();

            Console.WriteLine("");
            EnterKeyWait();
            monname = "백수왕 베헤모스";
            mon();
            bossbattle();

            Console.WriteLine("");
            EnterKeyWait();
            monname = "꼬마슬라임";
            mon();
            battle();

            Console.WriteLine("");
            EnterKeyWait();
            monname = "멍멍슬라임";
            mon();
            battle();

            Console.WriteLine("");
            EnterKeyWait();
            monname = "칼 슬라임";
            mon();
            battle();

            Console.WriteLine("");
            EnterKeyWait();
            monname = "헬멧 슬라임";
            mon();
            battle();
            boss2();
            Console.WriteLine("");
            EnterKeyWait();
            monname = "퀸 슬라임, 피오나";
            mon();
            bossbattle();

            Console.WriteLine("");
            EnterKeyWait();
            monname = "몽둥이 고블린";
            mon();
            battle();

            Console.WriteLine("");
            EnterKeyWait();
            monname = "침 고블린";
            mon();
            battle();

            Console.WriteLine("");
            EnterKeyWait();
            monname = "칼잡이 고블린";
            mon();
            battle();

            Console.WriteLine("");
            EnterKeyWait();
            monname = "도끼 고블린";
            mon();
            battle();
            boss3();
            Console.WriteLine("");
            EnterKeyWait();
            monname = "우두머리 고블린 마우";
            mon();
            bossbattle();
            Console.WriteLine(" 마우가 쓰러지고 그 주위에 고블린들은 꽥꽥 소리를 지르며 다들 달아났다. ");
            Console.WriteLine(" 마우 뒤로는 질퍽질퍽거리는 소리가 들려오는 큰 정글이 보인다. ");
            Console.WriteLine("그 정글로 들어가는 당신을 바라보는 무언가의 시선이 느껴진다.");
            Console.WriteLine("다음 학기 과제에 계속.");
            EnterKeyWait();




        }

        static void Page1()
        {
            Console.Clear();
            Console.WriteLine(" 어나더 던전 ");
            Console.WriteLine(" RPG 게임 임 알아서 잘 성장해서 보스 잡으면 끝 ");

        }

        static void Page2()
        {
            Console.Clear();
            Console.WriteLine(" 챕터 1 : 모험의 시작 ");
            Console.WriteLine(" 도시로 가는 길에 박쥐와 돼지들이 길을 방해하고 있다.");
            Console.WriteLine(" 저 깊은 숲속 뒤편에선 큰 울음소리가 들려온다. ");
        }
        static void boss1()
        {
            Console.WriteLine(" 쿵 쿵 쿵! ");
            EnterKeyWait();
            Console.WriteLine(" 쿵 쿵 쿵! ");
            EnterKeyWait();
            Console.WriteLine(" 무언가 거대한 것이 숲의 나무를 다 가로지르며 오고 있다. ");
            EnterKeyWait();
            Console.WriteLine(" 빨간 눈의 거대한 멧돼지가 뜨거운 입김을 내며 나를 향해 돌진해오고 있다.  ");
            EnterKeyWait();

        }
        static void boss2()
        {
            Console.WriteLine(" 스르륵...스르륵.. ");
            EnterKeyWait();
            Console.WriteLine(" 바닥에 파란색의 끈적한 물질이 한곳으로 모인다.. ");
            EnterKeyWait();
            Console.WriteLine(" 매력적으로 생긴 이쁘장한 여성의 생김새를 한 슬라임을 주위로 슬라임들이 모여든다. ");
            EnterKeyWait();

        }

        static void boss3()
        {
            Console.WriteLine(" 쿨... 쿨....");
            EnterKeyWait();
            Console.WriteLine(" 자고 있는 거대한 고블린과 그 주위로 많은 고블린들이 보초를 서있다. ");
            EnterKeyWait();
            Console.WriteLine(" 몰래 숨어들어가 보초 고블린을 죽이려는 순간, 눈을 번쩍 뜨곤 나를 향해 얼굴을 내민다. ");
            EnterKeyWait();

        }
        static void battle()
        {
            string k = "";

            Console.Clear();
            Console.WriteLine("몬스터 " + monname + " (이/가) 나타났다");
            turn = 1;
            for (; monhp > 0;)
            {

                Console.WriteLine(monname + " : " + monambassador);
                Console.WriteLine(monname + "의 체력 : " + monhp);
                Console.WriteLine("나의 체력 : " + hp);
                Console.WriteLine("1. 공격(" + attack + ") " + " / 2. 방어(" + defense + ") " + " / 3. 포션사용( 갯수 : " + porsion + ")");
                Console.Write("나의 행동번호 : ");
                ConsoleKeyInfo key = Console.ReadKey();
                k = key.Key.ToString();
                Console.WriteLine("");


                if (k == "D1")
                {
                    att();
                    if (hp <= 0)
                    {

                        Console.WriteLine(" I'm 패배에요");
                        EnterKeyWait();
                        Environment.Exit(0);
                    }
                    if (monhp <= 0)
                    {

                        Console.WriteLine("----!처치 완료!----");
                        Console.WriteLine(monexp + "경험치를 획득");
                        expbox += monexp;
                        Console.WriteLine("현재 경험치량 : " + maxexp + " / " + expbox);
                        Console.WriteLine(maxexp);
                        EnterKeyWait();
                        exp();

                        Console.Clear();

                    }
                }
                if (k == "D2")
                {
                    monhp -= defense / 3;

                    if (defense > monattack)
                    {

                        Console.WriteLine("몬스터의 공격력보다 방어력이 높아 방어하였습니다.");
                    }
                    else
                    {
                        hp -= monattack - defense;
                        Console.WriteLine(monattack - defense + "데미지를 입었습니다.");
                    }
                    Console.WriteLine(defense / 3 + "데미지를 입혔습니다.");
                    EnterKeyWait();
                    Console.Clear();
                    if (hp <= 0)
                    {

                        Console.WriteLine(" I'm 패배에요");
                        EnterKeyWait();
                        Environment.Exit(0);
                    }
                    if (monhp <= 0)
                    {

                        Console.WriteLine("----!처치 완료!----");
                        Console.WriteLine(monexp + "경험치를 획득");
                        expbox += monexp;
                        Console.WriteLine("현재 경험치량 : " + maxexp + " / " + expbox);
                        Console.WriteLine(maxexp);
                        EnterKeyWait();
                        exp();

                        Console.Clear();

                    }

                }
                if (k == "D3")
                {
                    if (porsion > 0)
                    {
                        hp += porsiongood;
                        hp -= monattack;
                        porsion -= 1;
                        Console.WriteLine(porsiongood+" 을 회복하였습니다.");
                        Console.WriteLine(monattack + "의 데미지를 입었습니다.");
                        EnterKeyWait();
                    }
                    if (porsion == 0)
                    {

                        hp -= monattack;

                        Console.WriteLine("포션이 없습니다.");
                        Console.WriteLine(monattack + "의 데미지를 입었습니다.");
                        EnterKeyWait();
                    }
                    Console.Clear();
                    if (hp <= 0)
                    {

                        Console.WriteLine(" I'm 패배에요");
                        EnterKeyWait();
                        Environment.Exit(0);
                    }
                }




                turn += 1;
            }

        }
        static void bossbattle()
        {
            string k = "";

            Console.Clear();
            Console.WriteLine("몬스터 " + monname + " (이/가) 나타났다");
            turn = 1;
            for (; monhp > 0;)
            {
                if (monname == "백수왕 베헤모스")
                {
                    if (0 == turn % skillturn)
                    {
                        Console.WriteLine(monname + "(이/가) 큰 울음소리를 내며 화를 냅니다.");
                        Console.WriteLine(monname + "의 공격력이 증가 합니다.");
                        EnterKeyWait();
                        monattack *= 1.2;
                    }
                }
                if (monname == "퀸 슬라임, 피오나")
                {
                    if (0 == turn % skillturn)
                    {
                        Console.WriteLine("주위 슬라임들이 " + monname + "에게로 모여든다.");
                        Console.WriteLine(monname + "의 체력이 증가 합니다.");
                        EnterKeyWait();
                        monhp *= 1.5;
                    }
                }
                if (monname == "우두머리 고블린 마우")
                {
                    if (turn == 2)
                    {
                        monattack = 250;
                        Console.WriteLine(monname + "(이/가) 큰 화를 내기 시작하더니 고블린 부하들에게 몽둥이를 가져오라 명령합니다.");
                        Console.WriteLine(monname + "의 공격력이" + monattack + "이 되었습니다.");
                        EnterKeyWait();
                    }
                    if (turn == 5)
                    {
                        monattack = 300;
                        Console.WriteLine(monname + "의 눈이 점점 빨개져갑니다.");
                        Console.WriteLine(monname + "의 공격력이" + monattack + "이 되었습니다.");
                        EnterKeyWait();
                    }
                    if (turn == 10)
                    {
                        monattack = 400;
                        Console.WriteLine(monname + "의 온몸이 빨개지기 시작하였습니다.");
                        Console.WriteLine(monname + "의 공격력이" + monattack + "이 되었습니다.");
                        EnterKeyWait();
                    }
                    if (turn == 15)
                    {
                        monattack = 500;
                        Console.WriteLine(monname + "(이/가) 기존의 덩치보다 훨씬 커졌으며, 비명소리에 귀가 뜯겨나갈거같습니다.");
                        Console.WriteLine(monname + "의 공격력이" + monattack + "이 되었습니다.");
                        EnterKeyWait();
                    }
                    if (turn ==20)
                    {
                        monattack = 10000;
                        Console.WriteLine(monname + "(이/가) : 죽기 직전 폭주하기 시작합니다.");
                        Console.WriteLine(monname + "의 공격력이" + monattack + "이 되었습니다.");
                        EnterKeyWait();

                    }
                }

                Console.Clear();
                Console.WriteLine(monname + " : " + monambassador);
                Console.WriteLine(monname + "의 체력 : " + monhp);
                Console.WriteLine("나의 체력 : " + hp);
                Console.WriteLine("1. 공격(" + attack + ") " + " / 2. 방어(" + defense + ") " + " / 3. 포션사용( 갯수 : " + porsion + ")");
                Console.Write("나의 행동번호 : ");
                ConsoleKeyInfo key = Console.ReadKey();
                k = key.Key.ToString();
                Console.WriteLine("");


                if (k == "D1")
                {
                    att();
                    if (hp <= 0)
                    {

                        Console.WriteLine(" I'm 패배에요");
                        EnterKeyWait();
                        Environment.Exit(0);
                    }
                    if (monhp <= 0)
                    {

                        Console.WriteLine("----!처치 완료!----");
                        Console.WriteLine(monexp + "경험치를 획득");
                        expbox += monexp;
                        Console.WriteLine("현재 경험치량 : " + maxexp + " / " + expbox);
                        Console.WriteLine(maxexp);
                        EnterKeyWait();
                        exp();

                        Console.Clear();

                    }

                }
                if (k == "D2")
                {
                    monhp -= defense / 3;

                    if (defense > monattack)
                    {

                        Console.WriteLine("몬스터의 공격력보다 방어력이 높아 방어하였습니다.");
                    }
                    else
                    {
                        hp -= monattack - defense;
                        Console.WriteLine(monattack - defense + "데미지를 입었습니다.");
                    }
                    Console.WriteLine(defense / 3 + "데미지를 입혔습니다.");
                    EnterKeyWait();
                    Console.Clear();
                    if (hp <= 0)
                    {

                        Console.WriteLine(" I'm 패배에요");
                        EnterKeyWait();
                        Environment.Exit(0);
                    }
                    if (monhp <= 0)
                    {

                        Console.WriteLine("----!처치 완료!----");

                        Console.WriteLine(monexp + "경험치를 획득");
                        expbox += monexp;
                        Console.WriteLine("현재 경험치량 : " + maxexp + " / " + expbox);
                        Console.WriteLine(maxexp);
                        EnterKeyWait();
                        exp();

                        Console.Clear();

                    }


                }
                if (k == "D3")
                {
                    if (porsion > 0)
                    {
                        hp += porsiongood;
                        hp -= monattack;
                        porsion -= 1;
                        Console.WriteLine(porsiongood + " 을 회복하였습니다.");
                        Console.WriteLine(monattack + "의 데미지를 입었습니다.");
                        EnterKeyWait();
                    }
                    if (porsion == 0)
                    {

                        hp -= monattack;

                        Console.WriteLine("포션이 없습니다.");
                        Console.WriteLine(monattack + "의 데미지를 입었습니다.");
                        EnterKeyWait();
                    }
                    Console.Clear();
                    if (hp <= 0)
                    {

                        Console.WriteLine(" I'm 패배에요");
                        EnterKeyWait();
                        Environment.Exit(0);
                    }
                }




                turn += 1;
            }

        }
        static void mon()
        {
            if (monname == "박쥐")
            {
                monhp = 30;
                monattack = 5;
                monexp = 1;
                monambassador = "꾸욱~꾸욱~";
            }
            if (monname == "돼지박쥐")
            {
                monhp = 100;
                monattack = 5;
                monexp = 2;
                monambassador = "꾸욱킁~ 꾸욱킁~";
            }
            if (monname == "멧돼지")
            {
                monhp = 200;
                monattack = 7;
                monexp = 3;
                monambassador = "꾸엑 꾸엑";
            }
            if (monname == "뿔멧돼지")
            {
                monhp = 100;
                monattack = 15;
                monexp = 5;
                monambassador = "꾸엑 꾸엑";
            }
            if (monname == "백수왕 베헤모스")
            {
                monhp = 1000;
                monattack = 40;
                monexp = 15;
                skillturn = 2;
                monambassador = "잠자는 나를 누가 깨웠는가";
            }
            if (monname == "꼬마슬라임")
            {
                monhp = 300;
                monattack = 20;
                monexp = 7;
                monambassador = "찍!.";
            }
            if (monname == "멍멍슬라임")
            {
                monhp = 400;
                monattack = 30;
                monexp = 7;
                monambassador = "월! 월!";
            }

            if (monname == "칼 슬라임")
            {
                monhp = 300;
                monattack = 40;
                monexp = 7;
                monambassador = "슈슉 슈슉";
            }
            if (monname == "헬멧 슬라임")
            {
                monhp = 600;
                monattack = 20;
                monexp = 7;
                monambassador = "뎃카이!";
            }
            if (monname == "퀸 슬라임, 피오나")
            {
                monhp = 2000;
                monattack = 50;
                monexp = 20;
                skillturn = 4;
                monambassador = "감히 누가 내 아이들을 괴롭히느냐";
            }
            if (monname == "몽둥이 고블린")
            {
                monhp = 1000;
                monattack = 50;
                monexp = 10;
                monambassador = "컄컄컄 후웅~";
            }
            if (monname == "침 고블린")
            {
                monhp = 500;
                monattack = 100;
                monexp = 13;
                monambassador = "쵹! 쵹!";
            }
            if (monname == "칼잡이 고블린")
            {
                monhp = 1000;
                monattack = 100;
                monexp = 15;
                monambassador = "슈슉 슈슉 슈슈슈발";
            }
            if (monname == "도끼 고블린")
            {
                monhp = 1500;
                monattack = 150;
                monexp = 20;
                monambassador = "푹찍 푹찍!";
            }
            if (monname == "우두머리 고블린 마우")
            {
                monhp = 10000;
                monattack = 200;
                monexp = 100;
                monambassador = "크헝헝 어디서 인간 냄새가 난다 크헝헝!";
            }
        }
        static void exp()
        {
            if (expbox >= maxexp)
            {
                level += 1;
                expbox = expbox - maxexp;
                maxexp = maxexp * 2;
                stats += 5;
                porsion += 10;
                porsiongood += 10;
                Console.WriteLine(level + "레벨이 되었습니다.");
                Console.WriteLine("포션 회복량이 10 증가 하였습니다.");
                Console.WriteLine("포션 10개를 획득 하였습니다.");
                Console.WriteLine("스탯창으로 넘어갑니다.");
                EnterKeyWait();
                Console.Clear();
                stat();
            }


        }
        static void stat()
        {
            for (; stats >= 1;)
            {
                Console.WriteLine("스탯 : " + stats);
                Console.WriteLine("----현재 수치----");
                Console.WriteLine("공격력 : " + attack);
                Console.WriteLine("방어력 : " + defense);
                Console.WriteLine("물약회복량 : " + porsiongood);
                Console.WriteLine("크리티컬 데미지 : " + Criticalhit);
                Console.WriteLine("1. 공격력 2. 방어력 3. 물약회복량 4. 크리티컬 데미지");
                Console.Write("번호를 입력하세요 : ");
                string k = "";

                ConsoleKeyInfo key = Console.ReadKey();
                k = key.Key.ToString();

                Console.Clear();
                if (k == "D1")
                {
                    if (work == 1)
                    {
                        attack += 5;
                    }
                    if (work == 2)
                    {
                        attack += 10;
                    }
                    if (work == 3)
                    {
                        attack += 15;
                    }
                    if (work == 4)
                    {
                        attack += 5;
                    }
                    if (work == 5)
                    {
                        attack += 5;
                    }
                    stats -= 1;
                }
                if (k == "D2")
                {
                    if (work == 1)
                    {
                        defense += 15;
                    }
                    if (work == 2)
                    {
                        defense += 7;
                    }
                    if (work == 3)
                    {
                        defense += 1;
                    }
                    if (work == 4)
                    {
                        defense += 10;
                    }
                    if (work == 5)
                    {
                        defense += 5;
                    }
                    stats -= 1;
                }
                if (k == "D3")
                {
                    if (work == 1)
                    {
                        porsiongood += 20;
                    }
                    if (work == 2)
                    {
                        porsiongood += 20;
                    }
                    if (work == 3)
                    {
                        porsiongood += 20;
                    }
                    if (work == 4)
                    {
                        porsiongood += 60;
                    }
                    if (work == 5)
                    {
                        porsiongood += 20;
                    }
                    stats -= 1;
                }
                if (k == "D4")
                {
                    if (work == 1)
                    {
                        Criticalhit += 0.5;
                    }
                    if (work == 2)
                    {
                        Criticalhit += 0.5;
                    }
                    if (work == 3)
                    {
                        Criticalhit += 0.5;
                    }
                    if (work == 4)
                    {
                        Criticalhit += 0.5;
                    }
                    if (work == 5)
                    {
                        Criticalhit += 2;
                    }
                    stats -= 1;
                }




            }
            Console.WriteLine("----현재 수치----");
            Console.WriteLine("공격력 : " + attack);
            Console.WriteLine("방어력 : " + defense);
            Console.WriteLine("물약회복량 : " + porsiongood);
            Console.WriteLine("현재 경험치량 : " + maxexp + " / " + expbox);
            EnterKeyWait();
        }
        static void att()
        {
            Random random = new Random();
            int randomValue = random.Next(100);

            if (randomValue < Critical)
            {
                monhp -= attack * Criticalhit;
                hp -= monattack;
                Console.WriteLine("크리티컬 발동!!");
                Console.WriteLine(monattack + "데미지를 입었습니다.");
                Console.WriteLine(attack * Criticalhit + "데미지를 입혔습니다.");
                EnterKeyWait();
                Console.Clear();
            }
            else
            {
                monhp -= attack;
                hp -= monattack;
                Console.WriteLine(monattack + "데미지를 입었습니다.");
                Console.WriteLine(attack + "데미지를 입혔습니다.");
                EnterKeyWait();
                Console.Clear();
            }
        }
        static void EnterKeyWait()
        {
            //키
            string k = "";
            Console.WriteLine("다음 [ENTER]");
            do
            {
                ConsoleKeyInfo key = Console.ReadKey(false);
                k = key.Key.ToString();
            } while (k != "Enter");
        }

    }
}
