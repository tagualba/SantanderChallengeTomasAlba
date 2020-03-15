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
                        
                        <b-form-group
                            id="input-group-1"
                            label="Email:"
                            label-for="input-3"
                        >
                            <b-form-input
                                id="input-3"
                                v-model="form.email"
                                type="email"
                                required
                                placeholder="someone@example.com"
                            >
                            </b-form-input>
                        </b-form-group> 

                        <b-form-group
                            id="input-group-1"
                            label="Primer Nombre"
                            label-for="input-4"
                        >
                            <b-form-input
                                id="input-4"
                                v-model="form.name"
                                type="text"
                                required
                                placeholder="Ingrese nombre"
                            >
                            </b-form-input>
                        </b-form-group>    

                        <b-form-group>
                            <b-form-checkbox
                                id="checkbox-1"
                                v-model="form.admin"
                                name="checkbox-1"
                                value="accepted"
                                unchecked-value="not_accepted"
                                >Admin
                                </b-form-checkbox>
                        </b-form-group>

                        <b-button type="submit" variant="primary">Registrar</b-button>
                    </b-form>
                </b-col>
                <b-col cols="0" md="3">
                </b-col>
            </b-row>
        </b-container>
  </div>
</template>

<script src="https://cdnjs.cloudflare.com/ajax/libs/vue-resource/1.5.1/vue-resource.min.js">
</script>
<script>
  export default {
    data() {
      return {
        form: {
          user: '',
          pass: '',
          email: '',
          name: '',
          admin:false
        },
        responseCreate:"",
        show: true
      }
    },
    methods: {
        onSubmit() {            
            this.registryUsersApi()//this.form.user,this.form.pass,this.form.email,this.form.name,this.form.admin)               
            if(this.responseCreate=="")
            {
                alert("Registrado con exito");
                this.$router.push({ name: 'Login' })
            }
                
            else
                alert("A ocurrido un error : "+ this.responseCreate);
            
        },
        registryUsersApi()
        {
            var vue = this;
            this.axios.get('https://localhost:5002/users/api/create',{params:{
                userName:this.form.user,
                name:this.form.name,
                pass:this.form.pass,
                email:this.form.email,
                admin:this.form.admin}

            })
                .then(function (response){  
                    console.log(response.data);                               
                    vue.responseCreate = response.data;
                })        
            
        }
    }
  }
</script>   