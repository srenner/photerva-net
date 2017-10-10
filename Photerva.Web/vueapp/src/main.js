// The Vue build version to load with the `import` command
// (runtime-only or standalone) has been set in webpack.base.conf with an alias.
import Vue from 'vue'
import App from './App'
import router from './router'
//import 'bootstrap'

import MainCalendar from './components/MainCalendar.vue'
Vue.component('main-calendar', MainCalendar)

Vue.config.productionTip = true

/* eslint-disable no-new */
new Vue({
  el: '#app',
  router,
  // template: '<App/>',
  render: function (createElement) {
    return createElement(App)
  },
  components: { App }
})
