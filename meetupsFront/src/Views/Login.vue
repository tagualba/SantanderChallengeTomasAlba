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
                                v-model="form.user"
                                type="text"
                                required
                                placeholder="Ingrese usuario"
                            >
                            </b-form-input>
                        </b-form-group>
                        
                        <b-form-group
                            id="input-group-1"
                            label="Contraseña:"
                            label-for="input-2"
                        >
                            <b-form-input
                                id="input-2"
                                v-model="form.pass"
                                type="password"
                                required
                                placeholder="Ingrese contraseña"
                            >
                            </b-form-input>
                        </b-form-group>                  
                        <b-button type="submit" variant="primary">Submit</b-button>
                        <router-link class="d-flex p-2" to="/registry">Desea Registrarse</router-link>                        
                                                
                    </b-form>
                </b-col>
                <b-col cols="0" md="3">
                </b-col>
            </b-row>
        </b-container>
  </div>
</template>

<script>
import {mapState,mapMutations} from 'vuex';

  export default {
    name:'login',
    computed:{
        ...mapState(['user'])
    },
    data() {
      return {
        form: {
          user: '',
          pass: '',
        },
        responseCreate:{
        },
        show: true,
        dismissSecs: 10,
        dismissCountDown: 0,
        showDismissibleAlert:false
      }
    },
   methods: {
       ...mapMutations(['asignar']),
        onSubmit() {
        
            //redireccionar
                
                this.checkLoginUserApi();                            
                
            /*else
            {
                this.showAlert();
            }*/
            
        },
        async checkLoginUserApi()
        {        
             
            let datos = await this.axios.get('https://localhost:5002/users/api/login',{
                params:{
                    userName:this.form.user,
                    pass:this.form.pass,
                }
            });
            alert(datos.data);
        }
        
    }
  }
</script>   