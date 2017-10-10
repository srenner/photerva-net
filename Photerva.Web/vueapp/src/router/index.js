import Vue from 'vue'
import Router from 'vue-router'
import Home from '../components/Home'

//import 'moment'
//import 'fullcalendar'

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/',
      name: 'Home',
      component: Home
    }
  ]
})
