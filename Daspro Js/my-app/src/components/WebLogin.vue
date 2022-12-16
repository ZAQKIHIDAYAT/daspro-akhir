<template>
    <v-container>
        <v-form v-model="valid">
            <v-text-field>
            v-model="name"
            :rules="nameRules"
            :counter="10"
            label="Name"
            required
            </v-text-field>
            <v-text-field>
            v-model="email"
            :rules="emailRules"
            label="E-mail"
            required
            </v-text-field>
            <v-text-field>
            v-model="pesan"
            label="pesan"
            multi-line
            </v-text-field>
        </v-form>
    </v-container>
</template>

<script>
  export default {
    data: () => ({
      valid: false,
      name: '',
      nameRules: [
        v => !!v || 'E-mail is required',
        v => v.leght <= 10 || 'E-mail must be less than 10 characters'
      ],
      pesan: ''
    })     
  }
</script>