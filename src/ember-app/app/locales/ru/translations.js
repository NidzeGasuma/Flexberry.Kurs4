import $ from 'jquery';
import EmberFlexberryTranslations from 'ember-flexberry/locales/ru/translations';

import IISKurs4ВыгрФайлаLForm from './forms/i-i-s-kurs4-выгр-файла-l';
import IISKurs4ЕдиИзмLForm from './forms/i-i-s-kurs4-еди-изм-l';
import IISKurs4ЗагрФайлаLForm from './forms/i-i-s-kurs4-загр-файла-l';
import IISKurs4КонвФайлыLForm from './forms/i-i-s-kurs4-конв-файлы-l';
import IISKurs4КонвертацияLForm from './forms/i-i-s-kurs4-конвертация-l';
import IISKurs4НастрКонвLForm from './forms/i-i-s-kurs4-настр-конв-l';
import IISKurs4РасширениеLForm from './forms/i-i-s-kurs4-расширение-l';
import IISKurs4ЭксФайлыLForm from './forms/i-i-s-kurs4-экс-файлы-l';
import IISKurs4ВыгрФайлаEForm from './forms/i-i-s-kurs4-выгр-файла-e';
import IISKurs4ЕдиИзмEForm from './forms/i-i-s-kurs4-еди-изм-e';
import IISKurs4ЗагрФайлаEForm from './forms/i-i-s-kurs4-загр-файла-e';
import IISKurs4КонвФайлыEForm from './forms/i-i-s-kurs4-конв-файлы-e';
import IISKurs4КонвертацияEForm from './forms/i-i-s-kurs4-конвертация-e';
import IISKurs4НастрКонвEForm from './forms/i-i-s-kurs4-настр-конв-e';
import IISKurs4РасширениеEForm from './forms/i-i-s-kurs4-расширение-e';
import IISKurs4ЭксФайлыEForm from './forms/i-i-s-kurs4-экс-файлы-e';
import IISKurs4ВыгрФайлаModel from './models/i-i-s-kurs4-выгр-файла';
import IISKurs4ЕдиИзмModel from './models/i-i-s-kurs4-еди-изм';
import IISKurs4ЗагрФайлаModel from './models/i-i-s-kurs4-загр-файла';
import IISKurs4КонвФайлыModel from './models/i-i-s-kurs4-конв-файлы';
import IISKurs4КонвертацияModel from './models/i-i-s-kurs4-конвертация';
import IISKurs4НастрКонвModel from './models/i-i-s-kurs4-настр-конв';
import IISKurs4РасширениеModel from './models/i-i-s-kurs4-расширение';
import IISKurs4Тч_загрModel from './models/i-i-s-kurs4-тч-загр';
import IISKurs4Тч_настрModel from './models/i-i-s-kurs4-тч-настр';
import IISKurs4ЭксФайлыModel from './models/i-i-s-kurs4-экс-файлы';

const translations = {};
$.extend(true, translations, EmberFlexberryTranslations);

$.extend(true, translations, {
  models: {
    'i-i-s-kurs4-выгр-файла': IISKurs4ВыгрФайлаModel,
    'i-i-s-kurs4-еди-изм': IISKurs4ЕдиИзмModel,
    'i-i-s-kurs4-загр-файла': IISKurs4ЗагрФайлаModel,
    'i-i-s-kurs4-конв-файлы': IISKurs4КонвФайлыModel,
    'i-i-s-kurs4-конвертация': IISKurs4КонвертацияModel,
    'i-i-s-kurs4-настр-конв': IISKurs4НастрКонвModel,
    'i-i-s-kurs4-расширение': IISKurs4РасширениеModel,
    'i-i-s-kurs4-тч-загр': IISKurs4Тч_загрModel,
    'i-i-s-kurs4-тч-настр': IISKurs4Тч_настрModel,
    'i-i-s-kurs4-экс-файлы': IISKurs4ЭксФайлыModel
  },

  'application-name': 'Конвертация',

  forms: {
    loading: {
      'spinner-caption': 'Данные загружаются, пожалуйста подождите...'
    },
    index: {
      greeting: 'Добро пожаловать на тестовый стенд ember-flexberry!'
    },

    application: {
      header: {
        menu: {
          'sitemap-button': {
            title: 'Меню'
          },
          'user-settings-service-checkbox': {
            caption: 'Использовать сервис сохранения пользовательских настроек'
          },
          'show-menu': {
            caption: 'Показать меню'
          },
          'hide-menu': {
            caption: 'Скрыть меню'
          },
          'language-dropdown': {
            caption: 'Язык приложения',
            placeholder: 'Выберите язык'
          }
        },
        login: {
          caption: 'Вход'
        },
        logout: {
          caption: 'Выход'
        }
      },

      footer: {
        'application-name': 'Конвертация',
        'application-version': {
          caption: 'Версия аддона {{version}}',
          title: 'Это версия аддона ember-flexberry, которая сейчас используется в этом тестовом приложении ' +
          '(версия npm-пакета + хэш коммита). ' +
          'Кликните, чтобы перейти на GitHub.'
        }
      },

      sitemap: {
        'application-name': {
          caption: 'Конвертация',
          title: 'Kurs4'
        },
        'application-version': {
          caption: 'Версия аддона {{version}}',
          title: 'Это версия аддона ember-flexberry, которая сейчас используется в этом тестовом приложении ' +
          '(версия npm-пакета + хэш коммита). ' +
          'Кликните, чтобы перейти на GitHub.'
        },
        index: {
          caption: 'Главная',
          title: ''
        },
        конвертация: {
          caption: 'Конвертация',
          title: 'Конвертация',
          'i-i-s-kurs4-загр-файла-l': {
            caption: 'Загрузка файла',
            title: ''
          },
          'i-i-s-kurs4-конв-файлы-l': {
            caption: 'Конвертированные файлы',
            title: ''
          },
          'i-i-s-kurs4-выгр-файла-l': {
            caption: 'Выгрузка файла',
            title: ''
          },
          'i-i-s-kurs4-конвертация-l': {
            caption: 'Конвертация',
            title: ''
          },
          'i-i-s-kurs4-экс-файлы-l': {
            caption: 'Эксель файлы',
            title: ''
          }
        },
        справочники: {
          caption: 'Справочники',
          title: 'Справочники',
          'i-i-s-kurs4-расширение-l': {
            caption: 'Расширение',
            title: 'Расширение'
          },
          'i-i-s-kurs4-настр-конв-l': {
            caption: 'Настройки конвертации',
            title: 'Настр конв'
          },
          'i-i-s-kurs4-еди-изм-l': {
            caption: 'Едениы измерения',
            title: 'Еди изм'
          }
        }
      }
    },

    'edit-form': {
      'save-success-message-caption': 'Сохранение завершилось успешно',
      'save-success-message': 'Объект сохранен',
      'save-error-message-caption': 'Ошибка сохранения',
      'delete-success-message-caption': 'Удаление завершилось успешно',
      'delete-success-message': 'Объект удален',
      'delete-error-message-caption': 'Ошибка удаления'
    },
    'i-i-s-kurs4-выгр-файла-l': IISKurs4ВыгрФайлаLForm,
    'i-i-s-kurs4-еди-изм-l': IISKurs4ЕдиИзмLForm,
    'i-i-s-kurs4-загр-файла-l': IISKurs4ЗагрФайлаLForm,
    'i-i-s-kurs4-конв-файлы-l': IISKurs4КонвФайлыLForm,
    'i-i-s-kurs4-конвертация-l': IISKurs4КонвертацияLForm,
    'i-i-s-kurs4-настр-конв-l': IISKurs4НастрКонвLForm,
    'i-i-s-kurs4-расширение-l': IISKurs4РасширениеLForm,
    'i-i-s-kurs4-экс-файлы-l': IISKurs4ЭксФайлыLForm,
    'i-i-s-kurs4-выгр-файла-e': IISKurs4ВыгрФайлаEForm,
    'i-i-s-kurs4-еди-изм-e': IISKurs4ЕдиИзмEForm,
    'i-i-s-kurs4-загр-файла-e': IISKurs4ЗагрФайлаEForm,
    'i-i-s-kurs4-конв-файлы-e': IISKurs4КонвФайлыEForm,
    'i-i-s-kurs4-конвертация-e': IISKurs4КонвертацияEForm,
    'i-i-s-kurs4-настр-конв-e': IISKurs4НастрКонвEForm,
    'i-i-s-kurs4-расширение-e': IISKurs4РасширениеEForm,
    'i-i-s-kurs4-экс-файлы-e': IISKurs4ЭксФайлыEForm
  },

});

export default translations;
