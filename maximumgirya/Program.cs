
Console.Write("Введите вес первой гири: ");

double firstgir = Convert.ToDouble (Console.ReadLine()) ;

Console.Write("Введите вес второй гири: ");

double secondgir =  Convert.ToDouble (Console.ReadLine()) ;

Console.Write("Введите вес третьей гири: ");

double thirdgir =  Convert.ToDouble (Console.ReadLine()) ;

Console.Write("Введите вес четвертой гири: ");

double fourthgir =  Convert.ToDouble (Console.ReadLine()) ;

Console.Write("Введите вес пятой гири: ");

double fifthgir =  Convert.ToDouble (Console.ReadLine()) ;

double maxim = firstgir;

if (firstgir > maxim) maxim = firstgir;
if (secondgir > maxim) maxim = secondgir;
if (thirdgir > maxim) maxim = thirdgir;
if (fourthgir > maxim) maxim = fourthgir;
if (fifthgir > maxim) maxim = fifthgir;

Console.WriteLine("Вес самой тяжелой гири равен: " + maxim);



