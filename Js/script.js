let prix = prompt("prix unitaire HT");
let articles = prompt("nombres articles");
let tva = prompt("taux TVA");
console.log(`prix total HT : ${prix * articles}`);
console.log(`prix total TTC : ${prix * articles * (1 + tva * 0.01)}`);
