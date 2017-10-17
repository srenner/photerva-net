<template>
  <div>
    <div id="mainCalendar"></div>
  </div>
</template>
<script>
//save for when i can fix webpack config
//import $ from "jquery";
//import moment from 'moment';
//import fullCalendar from 'fullcalendar';
export default {
  name: 'Home',
  data: function () {
    return {
      msg: 'this component is working'
    }
  },
  methods: {
    drawCalendar: function () {
      $('#mainCalendar').fullCalendar({
        //options
      });
    }
  },
  mounted: function () {

  },
  activated: function () {
    this.drawCalendar();
  }
}
</script>

<style src="fullcalendar/dist/fullcalendar.css"></style>
<style scoped>

</style>
