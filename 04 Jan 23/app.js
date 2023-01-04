// function longRunningTask(callback) {

//     setTimeout(() => {
//       const name = 'js';
//       callback(name);
//     },5000);
//   }

//   function printf (res) {
//     console.log(res);
//   }

//   longRunningTask(printf);

fetch('https://reqres.in/api/users').then(res => res.json()).then((data) =>{
    
    // for (let i = 0; i < data.data.length; i++) {
    //     console.log(data.data[i].email);
    // }

    data.data.forEach(element => {
        console.log(element.email);
    });
});