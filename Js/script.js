let array1 = [2, 5, 3, 10, 4, 2];
let i, j;
for (i = 1; i <= 6; i++) {
  console.log(array1[i - 1]);
  array1[i - 1] *= array1[i - 1];
}

for (j = 1; j <= 3; j++) {
  console.log(array1[j - 1]);
}

for (j = 4; j <= 6; j++) {
  console.log(array1[j - 1] * 2);
}
