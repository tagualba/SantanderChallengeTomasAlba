<template>
    <div >
        <br>
        <br>
        <br>
        <b-container >
            <b-row>
                <b-col cols="0" md="3">
                </b-col>
                <b-col cols="12" md="6">
                    <b-form @submit="onSubmit"  v-if="show">
                        <b-form-group
                            id="input-group-1"
                            label="Usuario:"
                            label-for="input-1"
                        >
                            <b-form-input
                                id="input-1"
                                v-model="form.title"
                                type="text"
                                required
                                placeholder="Ingrese el titulo"
                            >
                            </b-form-input>
                        </b-form-group>
                        
                        <b-form-group
                            id="input-group-1"
                            label="Fecha"
                            label-for="input-2"
                        >
                            <b-form-input
                                id="input-2"
                                v-model="form.date"
                                type="text"
                                required
                                placeholder="dd/mm/aaaa"
                            >
                            </b-form-input>
                        </b-form-group>
                        
                        <b-form-group
                            id="input-group-1"
                            label="Numero de personas"
                            label-for="input-3"
                        >
                            <b-form-input
                                @change="searcher()"
                                id="input-3"
                                v-model="form.npersonas"
                                type="text"                            
                                required
                                placeholder="0"
                            >
                            </b-form-input>
                            <br>
                            <p>La cerveza requerida son {{birra}} litros.</p>
                        </b-form-group>                                                               
                        <b-button type="submit" variant="primary">Guardar Meetup</b-button>
                    </b-form>
                </b-col>
                <b-col cols="0" md="3">
                </b-col>
            </b-row>
        </b-container>
  </div>
</template>

<script>
import { axios } from "axios";
  export default {
    data() {
      return {
        form: {
          title: '',
          date: '',
          npersons: '',
        },
        show: true,
        birra:0
      }
    },
    methods: {
        searcher() {
      var p = this.form.npersonas;
      var temp = this.getTempByDate();
    alert(temp);
      if(temp>24)
        this.birra = 2*p;
    else if(temp<20)
        this.birra = 0.75*p;
    else
        this.birra = p;    
    
  },
        getTempByDate(){
            
            return Math.random() * (35 - 10) + 10;
        },

        onSubmit() {
            var res = this.saveMeetupApi();//this.form.title,this.form.date,this.form.npersons,this.birra,1)//FALTAN LOS DATOS DEL USUARIO ORGANIZADOR
            if(res=="")
                alert("Programada Con exito!")                
            else
                alert("Hubo algun tipo de error intente denuevo mas tarde.")            
        },
        countDownChanged(dismissCountDown) {
            this.dismissCountDown = dismissCountDown
        },
        showAlert() {
            this.dismissCountDown = this.dismissSecs
        },
        saveMeetupApi(){//title,date,npersons,birra,idOrganizer){
            let datos = axios.get('');
            if(datos!=null)
                return true;
            return false;
        }
    }
  }
</script>   