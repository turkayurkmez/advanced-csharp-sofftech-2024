// See https://aka.ms/new-console-template for more information
using EnumTypes;

Console.WriteLine("Hello, World!");

Student student = new Student();
student.State = StudentState.Graduate;

switch (student.State)
{
	case StudentState.Graduate:
		break;
	case StudentState.Canceled:
		break;
	case StudentState.Failed:
		break;
	case StudentState.Unknown:
		break;
	default:
		break;
}

var akrabalik = AkrabalikTip.Baba | AkrabalikTip.Amca | AkrabalikTip.Abi | AkrabalikTip.Dayi | AkrabalikTip.Ogul | AkrabalikTip.Dede;

Console.WriteLine(akrabalik);