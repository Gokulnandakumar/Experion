const passengers = ['Athul', 'Ramesh', 'Bibin', 'Deepak', 'Hari', 'Ramu', 'Rajesh', 'Sojan', 'Ashwin', 'Karnan'];
function alphabeticalSort(passengers) {
    let swap ;
    for (let i = 0; i < passengers.length; i++) {
       for (let j = 0; j < passengers.length-i-1; j++) {
           if(passengers[j] > passengers[j+1]) 
           {
             swap =  passengers[j];
             passengers[j] = passengers[j+1];
             passengers[j+1] = swap;
           }
       } 
    //    console.log(swap); 
    }
    console.log(passengers);
}


alphabeticalSort(passengers);
// for (let index = 0; index < passengers.length; index++) {
//     console.log(duplicate[index]);
// }



