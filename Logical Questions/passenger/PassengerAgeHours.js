// AGE OF PASSENGER
const person = 'july 9 2001';
const age = new Date(person);

//Age of PASSENGER in Years
let year = age.getFullYear();
let currentYear = 2023;
let AgeInYear = currentYear - year ;
console.log('age in years ' + AgeInYear);

//Age of Passenger in Months
let dobMonth = age.getMonth() ;
const month = new Date();
const months = month.getMonth();
// console.log(currentMonth, months);
let fin = months - dobMonth;
let TotalMonth = AgeInYear * 12; 
let cal ;
if(fin < 0) {
    cal = TotalMonth - fin;
    console.log(cal);
} else {
    cal = TotalMonth + fin
    console.log(cal);
}
// let AgeInMonths = currentMonth + TotalMonth;


//Age of passenger in weeks.

let weeks = (cal * 4);
const date = new Date();
const day = date.getDate();
console.log(day);
