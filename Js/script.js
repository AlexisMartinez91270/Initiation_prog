let array1 = new Array(5);
let i;
for (i = 1; i <= array1.Length; i++) {
  array1[i - 1] = i * i;
  console.log(array1[i - 1]);
}
