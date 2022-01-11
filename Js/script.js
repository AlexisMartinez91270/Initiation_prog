let capIni, cap, taux;

capIni = prompt("donnez le capital à placer : ");
taux = prompt("donnez le taux : ");

cap = capIni;
let i = 0;

do {
  cap = cap * (1 + taux / 100);
  i++;
  console.log(`capital, à l'année ${i} : ${cap}`);
} while (cap <= 2 * capIni);
