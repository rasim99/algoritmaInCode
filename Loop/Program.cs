

///----------------------------------------------- Task0 ededin menfi veya musbet olmagini yoxlamaq

//int number = Convert.ToInt32(Console.ReadLine());

//if (number > 0)
//{
//    Console.WriteLine("number is positive");
//}
//else
//{
//    Console.WriteLine("number is negative");
//}

//*******************************************************************************************************************************
//###############################################################################################################################


//-------------------------------------------- Task1 ixtiyari 5 ededin cemi 

//Console.WriteLine("Ixtiyari 5 eded daxil edin ve cemini gorun");
//int i = 1;
//int sum = 0;
//while (i <= 5)
//{
//    int num = Convert.ToInt32(Console.ReadLine());
//    sum += num;
//    i++;
//}
//Console.WriteLine(sum);

//*******************************************************************************************************************************
//###############################################################################################################################


//  -------------------------------------------  Task2 ededin kvadrati 
//int num = Convert.ToInt32(Console.ReadLine());
//int square = num * num;
//Console.WriteLine(square);

//*******************************************************************************************************************************
//###############################################################################################################################


// ----------------------------------------------------- Task3 ixtiyari daxil edilmis 3 ededden boyuyu 
//Console.WriteLine("ilk ededi daxil edin");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("ikinci ededi daxil edin");
//int b = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("3cu  ededi daxil edin");
//int c = Convert.ToInt32(Console.ReadLine());
// if (a >b && a>c)
//{
//    Console.WriteLine($"en boyuk eded:{a}");
//}
// else if (b > c)
//{
//    Console.WriteLine($"en boyuk eded:{b}");
//}
// else if(a==b && b==c)
//{
//    Console.WriteLine("her 3 eded beraberdir");
//}
//else
//{
//    Console.WriteLine($"en boyuk eded:{c}");
//}

//*******************************************************************************************************************************
//###############################################################################################################################


//  Task4  İki ixtiyari ədəd daxil edilir, birinci daxil edilən ədədin kubunun ikinci daxil ədəddən böyük olub olmadığını tapmaq.

//Console.WriteLine("ilk ededi daxil edin");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("ikinci ededi daxil edin");
//int b = Convert.ToInt32(Console.ReadLine());
//int a3 = a * a * a;
//if (a3 > b)
//{
//    Console.WriteLine($"ilk ededin kubu boyukdur ikinci ededden");

//}
//else if (a3 == b)
//{
//    Console.WriteLine($"ilk ededin kubu  beraberdir ikinci edede");

//}
//else
//{
//    Console.WriteLine($"ilk ededin kubu kicikdir ikinci ededden");


//}

//*******************************************************************************************************************************
//###############################################################################################################################


//  ------------------------------    Task5   Ededin hem 3e, hem 5e bolunub bolunmemesini tapan alqoritma
//int a = Convert.ToInt32(Console.ReadLine());
//if (a % 3 == 0 && a % 5 == 0)
//{
//    Console.WriteLine($"{a} hem 3e hem de 5e bolunur");
//}
//else if (a % 3 == 0)
//{
//    Console.WriteLine($"{a} tekce 3e bolunur");
//}
//else if (a % 5 == 0)
//{
//    Console.WriteLine($"{a} tekce 5e bolunur");
//}
//else
//{
//    Console.WriteLine($"{a} ne 3e ne de 5e bolunmur");

//}


//*******************************************************************************************************************************
//###############################################################################################################################


// Task6 Input olaraq kartdaki mebleg ve mehsulun meblegi goturulur, kartdaki meblegin mehsulu almaga yeterli olub olmadigini tap
//Console.WriteLine(" cash-i daxil et ");
//int cash = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(" price-ni daxil et ");
//int price = Convert.ToInt32(Console.ReadLine());
//if (cash >= price)
//{
//    Console.WriteLine("mehsulu ala biler");
//}
//else
//{
//    Console.WriteLine("mehsulu ala bilmez");

//}
//*******************************************************************************************************************************
//###############################################################################################################################


//Task7  Telebe 5 fennden imtahan vererek her birinden bal alib, ortalama bal 65den yuxaridisa telebe semestri kecmis sayilir.
//Input olaraq daxil edilmis ballardan istifade ederek telebenin imtahandan kecib kecmediyini tapan alqoritma

//int ortalama = 0;
//int fensayi = 5;
//int cemqiymet = 0;
//for (int i = 1; i <= fensayi; i++)
//{
//    Console.WriteLine("fen qiymetini yazin");
//InitialLine: int point = Convert.ToInt32(Console.ReadLine());
//    if (point > 0 && point <= 100)
//    {
//        cemqiymet += point;
//    }
//    else
//    {
//        goto InitialLine;

//    }
//}
//ortalama = cemqiymet / fensayi;
//if (ortalama >= 65)
//{
//    Console.WriteLine("ugurla kecdiniz");
//}
//else
//{
//    Console.WriteLine("teesuf kesrdir");
//}

//*******************************************************************************************************************************
//###############################################################################################################################


//--------------  Task8 Input olaraq daxil edilmis iki natural ededden hansinin boyuk oldugunu tapan alqoritma

//InitialLine: Console.WriteLine("ilk ededi daxil edin");
// int num1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("ikinci ededi daxil edin");

// int num2 = Convert.ToInt32(Console.ReadLine());
//if (num1 > 0 && num2 > 0)
//{
//    if (num1 > num2)
//    {
//        Console.WriteLine($"{num1} > {num2}");
//    }
//    else if (num1 == num2)
//    {
//        Console.WriteLine($"{num1} == {num2}");
//    }
//    else
//    {
//        Console.WriteLine($"{num2} > {num1}");
//    }
//}
//else
//{
//    Console.WriteLine("Natural eded daxil edin");
//    goto InitialLine;
//}

//*******************************************************************************************************************************
//###############################################################################################################################


// Task9 Input olaraq daxil edilmis temperature derecesinin suyun donma temperaturundan asagi ve ya yuxari oldugunu teyin etmek

//int deg=Convert.ToInt32(Console.ReadLine());
//if (deg == 0)
//{
//    Console.WriteLine("Suyun donma derecesidir");
//}
//else if(deg>0){
//    Console.WriteLine("Suyun donma derecesiden yuxaridir");
//}
//else
//{
//    Console.WriteLine("Suyun donma derecesiden asagidir");

//}

//___________________________________-------------------------------------------------________________________________________
// -----------------------------------------------   NEXT LEVEL        -------------------------------------------------------
//___________________________________-------------------------------------------------________________________________________

//------------------------------------ Task1 50ə qədər olan ədədləri artan sıra ilə göstərmək (0 ve 50 daxil)--------------------------------------

//for (int i = 0; i <= 50; i++)
//{
//    Console.WriteLine(i);
//}

//*******************************************************************************************************************************
//*******************************************************************************************************************************


//--------------------------------------- Task2 40a qədər 3ə bölünən ədədlərin sayını tapmaq (0 daxil deyil)


//int count = 0;
//for (int i = 1; i <=40; i++)
//{
//    if (i % 3 == 0)
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);

//*******************************************************************************************************************************
//*******************************************************************************************************************************


//--------------------------------------- Task3 100ə qədər həm 3ə həm 7ə bölünən ədədləri tapmaq və göstərmək

//for (int i = 0; i < 100; i++)
//{
//	if (i % 3 == 0 && i % 7 == 0)
//	{
//		Console.WriteLine(i);
//	}
//}

//*******************************************************************************************************************************
//*******************************************************************************************************************************


//-------------------------------------  Task4  Ədədin rəqəmlərinin sayını tapmaq

//int num = Convert.ToInt32(Console.ReadLine());
//int count = 0;
//while (num > 0)
//{
//    num /= 10;
//    count++;
//}
//Console.WriteLine(count);

//*******************************************************************************************************************************
//*******************************************************************************************************************************


//--------------------------------  Task5 Ədədi tərsinə yazmaq

//int num = Convert.ToInt32(Console.ReadLine());
//int temp = 0;

//while (num > 0)
//{
//    temp = (temp * 10) + num % 10;
//    num /= 10;
//}
//Console.WriteLine(temp);

//*******************************************************************************************************************************
//*******************************************************************************************************************************


//-------------------------------  Task6  Ədədin faktorialini tapmaq

//int num = Convert.ToInt32(Console.ReadLine());
//int f = 1;
//for (int i = 1; i <= num; i++)
//{
//    f *= i;

//}
//Console.WriteLine(f);

//*******************************************************************************************************************************
//*******************************************************************************************************************************


//---------------------------  Task7   Ədədin sadə və ya mürəkkəb olduğunu tapmaq

//int num=Convert.ToInt32(Console.ReadLine());
//bool isPrimitive = true;
//for (int i = 2; i < num; i++)
//{
// if (num%i == 0)
//    {
//        isPrimitive = false;
//    }
//}

//if (isPrimitive)
//{
//    Console.WriteLine("sade");
//}
//else
//{
//    {
//        Console.WriteLine(" Murekkeb");
//    }
//}

//*******************************************************************************************************************************
//*******************************************************************************************************************************


//----------------------------------  Task8  Ədədin rəqəmlərinin cəminin tapmaq

//int num = Convert.ToInt32(Console.ReadLine());
//int sum = 0;
//while (num > 0)
//{
//    int c = num % 10;
//    sum += c;
//    num /= 10;
//}
//Console.WriteLine(sum);

//*******************************************************************************************************************************
//*******************************************************************************************************************************


//--------------------------------------  Task9 Ədədin rəqəmləri içərisində ən böyüyü tapmaq

//int num = Convert.ToInt32(Console.ReadLine());
//int reqem;
//int max = 0;
//while (num > 0)
//{
//    reqem = num % 10;
//    if (reqem > max)
//    {
//        max = reqem;
//    }
//    else
//    {
//        num /= 10;
//    }
//}
//Console.WriteLine(max);

//*******************************************************************************************************************************
//*******************************************************************************************************************************


//----------------------------------- Task10 70dən kiçik olan ədədlərdən cüt olanları azalan sıra ilə göstərmək
//for (int i=70; i >0; i--)
//{
//	if (i%2==0)
//	{
//		Console.WriteLine(i);
//	}
//}

//*******************************************************************************************************************************
//*******************************************************************************************************************************


//----------------------------------  Task11 Ilin fesli daxil edilir. Meselen 11. Cavab olaraq: Noyabr, Payiz feslidir

//int num=Convert.ToInt32(Console.ReadLine());
//switch (num)
//{
//	case 1:Console.WriteLine("Yanvar Qis fesli");	
//		break;
//		case 2:Console.WriteLine("Fevral Qis fesli"); break;
//		case 3:Console.WriteLine("Mart Yaz fesli"); break;
//		case 4:Console.WriteLine("Aprel Yaz fesli"); break;
//		case 5:Console.WriteLine("May yaz fesli");break;
//		case 6:Console.WriteLine("Iyun yay fesli");	break; 
//	    case 7:Console.WriteLine("Iyul yay fesli"); break;
//		case 8:Console.WriteLine("Avqust yay fesli");break;
//		case 9:Console.WriteLine("Sentyabr payiz fesli");break;
//		case 10:Console.WriteLine("Oktyabr payiz fesli");break;
//		case 11:Console.WriteLine("Noyabr payiz fesli");break;
//		case 12:Console.WriteLine("Dekabr qis fezli");break;
//	default: Console.WriteLine("Duzgun tarix qeyd edilmedi");
//		break;
//}

//*******************************************************************************************************************************
//*******************************************************************************************************************************


//___________________________________-------------------------------------------------________________________________________
// ---------------------------------------------   NEXT LEVEL * Tasklari    --------------------------------------------------
//___________________________________-------------------------------------------------________________________________________

//11
//*****
//*****
//*****
//*****
//*****

//int num=Convert.ToInt32(Console.ReadLine());
//for(int i=1; i<=num; i++)
//{
//    Console.WriteLine(new string('*',num));   
//}


//++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++



//12
//*
//**
//***
//****

//int num=Convert.ToInt32(Console.ReadLine());
//for (int i = 0; i <= num; i++)
//{
//    Console.WriteLine(new string('*',i));
//}


//++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//13
//****
//***
//**
//*

//int num = Convert.ToInt32(Console.ReadLine());
//{
//	for (int i =num; i >0; i--)
//	{
//		Console.WriteLine(new string('*', i));
//	}
//}

//++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
// ____________________________________________________________COMPLETED_________________________________________________________
//++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
