let notes = [
  4, 18, 20, 9, 15, 3, 7, 17, 12, 13, 1, 16, 14, 8, 9, 10, 13, 9, 5, 18,
];
let i,
  n,
  percent,
  nSup10 = 0;

for (i = 0; i < notes.length; i++) {
  n = notes[i];
  if (n > 10) {
    nSup10++;
  }
}
percent = (nSup10 * 100) / i;
console.log(percent);
