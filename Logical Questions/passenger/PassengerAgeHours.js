// AGE OF PASSENGER
const age = new Date('FEB 24 1989');

//Age of PASSENGER in Years
let year = age.getFullYear();
let currentYear = 2023;
let AgeInYear = currentYear - year ;
console.log('age in years ' + AgeInYear);

//Age of Passenger in Months
let currentMonth = age.getMonth();
let TotalMonth = AgeInYear * 12;
let AgeInMonths = currentMonth + TotalMonth;
console.log('age in months ' + AgeInMonths);
