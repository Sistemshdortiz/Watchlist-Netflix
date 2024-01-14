<!-- src/components/Register.vue -->
<template>
    <div>
        <h2>Register</h2>
        <form @submit.prevent="register">
            <label for="newUsername">Username:</label>
            <input type="text" id="newUsername" v-model="newUsername" required />
            <br />
            <label for="newPassword">Password:</label>
            <input type="password" id="newPassword" v-model="newPassword" required />
            <br />
            <button type="submit">Register</button>
        </form>
    </div>
</template>

<script>export default {
    data() {
      return {
        newUsername: '',
        newPassword: '',
      };
    },
    methods: {
      register() {
        // Add your registration logic here
        console.log('Registering:', this.newUsername, this.newPassword);
      },
    },
  };</script>