// 단어장 랜덤 테스트기 Ver.콘솔

var dic = new Dictionary<string, string>() 
{

    {"seldom", "거의 ~하지 않는, 드물게"},
    {"as if", "마치 ~인듯이"},
    {"embrace", "받아들이다, 포용하다"},
    {"concrete", "구체적인"},
    {"drop by", "잠깐들리다"},
    {"up-and-down", "오르내리는, 기복이 있는"},
    {"shortage", "부족, 결핍"},
    {"govern", "통치하다, 지배하다"},
    {"venue", "장소"},
    {"in storage", "보관중인"},
    {"parcel", "소포"},
    {"dine", "식사를 하다"},
    {"as long as", "~하는 한"},
    {"prize", "상품"},
    {"cab", "택시"},
    {"cite", "언급하다"},
    {"somewhat", "다소"},
    {"paycheck", "급료, 급료 지불 수표"},
    {"cover letter", "자기소개서"},
    {"excel", "능가하다, ~보다 낫다"},
    {"assess", "평가하다"},
    {"suspect", "용의자, 의심하다"},
    {"conclusive", "결정적인, 단호한"},
    {"halfway", "중간에"},
    {"in light of", "~를 고려하여"},
    {"get along with", "~와 사이좋게 지내다"},
    {"count on", "~를 믿다, ~에 의지하다"},
    {"observant", "관찰력이있는"},
    {"municipal", "자치도시의, 시립의"},
    {"out of order", "고장 난"},
    {"modestly", "겸손하게"},
    {"call off", "취소하다"},
    {"feasible", "실행 가능한"},
    {"get over", "극복하다"},
    {"ample", "충분한, 풍부한"},
    {"tedious", "지루한, 싫증나는"},
    {"fluctuation", "변동, 오르내림"},
    {"by no means", "결코 ~이 아닌"},
    {"by check", "수표로"},
    {"breakthrough", "비약적인 발전"},
    {"adversely", "불리하게"},
    {"outlast", "~보다 오래가다"},
    {"evidently", "분명히, 명백히"},
    {"make public", "발표하다"},
    {"ready-made", "기성품의"},
    {"makeup", "조립, 구성"},
    {"sort out", "~을 정리하다"},
    {"redeem", "상품으로 교환하다, 값다, 상환하다"},
    {"comply with", "~에 따르다"},
    {"travel arrangement", "여행 준비"}

};

var wrongdic = new Dictionary<string, string>();

int count = 0;
int wCount = 0;
string answer;
string score;

Console.Clear();
Console.WriteLine("Press \'any Key\' to Start !");
Console.ReadLine();

Random random = new Random();

// 랜덤으로 10개만 뽑아서 테스트 실행
List<KeyValuePair<string, string>> selectWords = dic.OrderBy(x => random.Next()).Take(10).ToList();

foreach (KeyValuePair<string, string> item in selectWords) {
    
    count += 1;
    Console.WriteLine("---------------------------------------------");
    Console.WriteLine($"{count}. {item.Key}\n");
    Console.WriteLine("Your answer : ");
    answer = Console.ReadLine();

    Console.WriteLine("\n[{0} : {1}]\n", item.Key, item.Value);

    Console.WriteLine("Select the Score Correct(y) or Wrong(n) : (y/n)\n");
    score = Console.ReadLine();
    score = score.ToLower();

    if (score == "y") {
        Console.WriteLine("\nNice !\n");
    }

    else if (score == "n") {
        wrongdic.Add(item.Key, item.Value);
        Console.WriteLine("\nCheck it after the test :(\n");
    }
    
    
}

Console.WriteLine("Check your Wrong Words in your Recheck-List.\n");

foreach (KeyValuePair<string, string> wrongWord in wrongdic) {

    wCount += 1;
    Console.WriteLine($"{wCount}:\n");
    Console.WriteLine("\n[{0} : {1}]\n", wrongWord.Key, wrongWord.Value);

}

Console.WriteLine($"\nTotal Wrong count : {wCount}");
