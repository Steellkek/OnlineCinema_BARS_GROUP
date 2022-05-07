//живой поиск
window.onload=() =>{
    let input= document.querySelector('#input')
    input.oninput=function (){
        let value = this.value.trim();
        let list = document.querySelectorAll(".col-3")
        //console.log(list)
        //console.log(list[0].getElementsByTagName('h5')[0].innerText)
        if(value){
            list.forEach(elem=>{
                if(elem.getElementsByTagName('h5')[0].innerText.toLowerCase().search(value) ===-1){
                    elem.classList.add('hide')
                }
                else{
                    elem.classList.remove('hide')
                }
            });
        }else
        {
            list.forEach(elem=>{
                elem.classList.remove('hide')
            })
        }

    }
}

