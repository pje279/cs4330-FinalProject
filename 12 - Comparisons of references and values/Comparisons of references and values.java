int x = 1;
int y = 2;
int z = 1;

if (x == y) {
  //False
}

if (x == z) {
  //True
}

String string1 = "Lorem ipsum";
String string2 = "Lorem ipsum";

if (string1 == string2) {
  //Only true if the have the same address, which they probably don't
}

if (string1.equals(string2) {
  //True
}
