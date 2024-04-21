    double catetoA, catetoB, hipotenusa;

    Console.Write("Digite o valor do cateto A: ");
    catetoA = double.Parse(Console.ReadLine());

    Console.Write("Digite o valor do cateto B: ");
    catetoB = double.Parse(Console.ReadLine());

    // calculando a hipotenusa 
    hipotenusa = (catetoA * catetoA + catetoB * catetoB);

    // exibindo o valor da hipotenusa
    Console.WriteLine("A hipotenusa do triângulo é: {0}", hipotenusa);