let array1 = new Array(200);
let i;
let max = array1[0];
let maxPos = 0;

for (i = 1; i < array1.length; i++) {
  array1[i] = i;
  if (array1[i] > max) {
    max = array1[i];
    maxPos = i;
  }
}
console.log(maxPos);
