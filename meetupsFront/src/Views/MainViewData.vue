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
  
    <b-table sticky-header :items="items" :fields="fields"><template v-slot:cell(actions)="row">
            <b-button size="sm" variant="success" :to="`/quotes/${row.item.id}/view`" v-b-tooltip.hover :title="$t('buttons.preview')" class="mr-1">
              <i class="fe fe-eye"></i>
            </b-button>
            <b-button v-if="row.item.id" size="sm" variant="primary" :to="`/quotes/${row.item.id}/edit`" v-b-tooltip.hover :title="$t('buttons.edit')" class="mr-1">
              <i class="fe fe-edit"></i>
            </b-button>
            <b-button v-if="row.item.id" size="sm" variant="danger" v-b-tooltip.hover :title="$t('buttons.delete')" @click.stop="onDelete(row.item.id)">
              <i class="fe fe-trash"></i>
            </b-button>
          </template></b-table>
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