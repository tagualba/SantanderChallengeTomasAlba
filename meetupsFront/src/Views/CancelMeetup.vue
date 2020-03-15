<template>
  <div>
      <br><br>
        <div>
            <router-link to="/foo" >
                <b-button>Crear</b-button>
            </router-link>

            <router-link to="/foo" >
                <b-button>Eliminar</b-button>
            </router-link>

            <router-link to="/foo" >
                <b-button>Cancelar</b-button>
            </router-link>
        
        </div>
        <br>
  
    <b-table sticky-header :items="items" :fields="fields"></b-table>
  </div>
</template>
<script>
  export default {
    data() {
      return {
        // Note `isActive` is left out and will not appear in the rendered table
        fields: ['Titulo', 'Creador', 'Fecha','Temperatura°','Numero de Invitados'],
        items: [
          { isActive: true, Titulo: 40, Creador: 'Dickerson', Fecha: 'Macdonald',Temperatura:'',Invitados:10 },
          { isActive: true, Titulo: 40, Creador: 'Dickerson', Fecha: 'Macdonald',Temperatura:'',Invitados:10 },
          { isActive: true, Titulo: 40, Creador: 'Dickerson', Fecha: 'Macdonald',Temperatura:'',Invitados:10 },
          { isActive: true, Titulo: 40, Creador: 'Dickerson', Fecha: 'Macdonald',Temperatura:'',Invitados:10 },
          { isActive: true, Titulo: 40, Creador: 'Dickerson', Fecha: 'Macdonald',Temperatura:'',Invitados:10 },
          { isActive: true, Titulo: 40, Creador: 'Dickerson', Fecha: 'Macdonald',Temperatura:'',Invitados:10 },
          { isActive: true, Titulo: 40, Creador: 'Dickerson', Fecha: 'Macdonald',Temperatura:'',Invitados:10 },
          { isActive: true, Titulo: 40, Creador: 'Dickerson', Fecha: 'Macdonald',Temperatura:'',Invitados:10 },
          { isActive: true, Titulo: 40, Creador: 'Dickerson', Fecha: 'Macdonald',Temperatura:'',Invitados:10 },
          { isActive: true, Titulo: 40, Creador: 'Dickerson', Fecha: 'Macdonald',Temperatura:'',Invitados:10 },
          { isActive: true, Titulo: 40, Creador: 'Dickerson', Fecha: 'Macdonald',Temperatura:'',Invitados:10 },
          { isActive: true, Titulo: 40, Creador: 'Dickerson', Fecha: 'Macdonald',Temperatura:'',Invitados:10 },
          { isActive: true, Titulo: 40, Creador: 'Dickerson', Fecha: 'Macdonald',Temperatura:'',Invitados:10 },
          { isActive: true, Titulo: 40, Creador: 'Dickerson', Fecha: 'Macdonald',Temperatura:'',Invitados:10 },
          { isActive: true, Titulo: 40, Creador: 'Dickerson', Fecha: 'Macdonald',Temperatura:'',Invitados:10 },
          { isActive: true, Titulo: 40, Creador: 'Dickerson', Fecha: 'Macdonald',Temperatura:'',Invitados:10 },
          { isActive: true, Titulo: 40, Creador: 'Dickerson', Fecha: 'Macdonald',Temperatura:'',Invitados:10 },
          { isActive: true, Titulo: 40, Creador: 'Dickerson', Fecha: 'Macdonald',Temperatura:'',Invitados:10 },
          { isActive: true, Titulo: 40, Creador: 'Dickerson', Fecha: 'Macdonald',Temperatura:'',Invitados:10 },
          { isActive: true, Titulo: 40, Creador: 'Dickerson', Fecha: 'Macdonald',Temperatura:'',Invitados:10 }
        ]
      }
    }
  }
</script>