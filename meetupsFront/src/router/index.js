import Vue from 'vue'
import VueRouter from 'vue-router'
import Login from '../Views/Login.vue'
import Registry from '../Views/Registry.vue'
import MainTable from '../Views/MainViewData.vue'
import CreateMeetup from '../Views/CreateMeetup.vue'

Vue.use(VueRouter)

const routes = [
  {
    path: '/',
    name: 'Login',
    component: Login
  },
  {
    path: '/registry',
    name: 'Registry',
    component: Registry
  },
  {
    path: '/mainTable',
    name: 'mainTable',
    component: MainTable
  },
  {
    path: '/createMeetup',
    name: 'createMeetup',
    component: CreateMeetup
  }
]

const router = new VueRouter({
  mode: 'history',
  base: process.env.BASE_URL,
  routes
})

export default router
