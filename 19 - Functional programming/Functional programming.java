Function<Integer,Integer> add1 = x -> x + 1;
Function<String,String> concat = x -> x + 1;

Integer two = add1.apply(1); //yields 2;
String answer = concat1.apply("0 + 1 = "); //yields "0 + 1 = 1";
