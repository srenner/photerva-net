<template>
  <div>
    <div id="mainCalendar"></div>
    {{msg}}
  </div>
</template>
<script>
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
      //debugger;
      this.msg = moment().format('YYYY [escaped] YYYY');

      $('#mainCalendar').fullCalendar({
        //options
      });
    }
  },
  mounted: function () {

  },
  activated: function () {
    //alert(JSON.stringify(fullcalendar))
    //debugger;
    this.drawCalendar();
  }
}
</script>

<style src="fullcalendar/dist/fullcalendar.css"></style>
<style scoped>

</style>
