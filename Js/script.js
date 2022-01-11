let array1 = new Array(8);
let i;

array1[0] = 1;
array1[1] = 1;

for (i = 2; i < array1.length; i++) {
  array1[i] = array1[i - 1] + array1[i - 2];
}

for (i = 0; i < array1.length; i++) {
  console.log(array1[i]);
}
