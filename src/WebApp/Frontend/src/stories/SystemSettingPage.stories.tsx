import { Meta, Story } from "@storybook/react/types-6-0";
import SystemSettingPage from "../pages/SystemSettingPage";
import StoryRouter from 'storybook-react-router';

export default {
    title: "pages/SystemSettingPage",
    decorators: [StoryRouter()],
    components: SystemSettingPage,
} as Meta;

const Template: Story = () => <SystemSettingPage />;

export const Default = Template.bind({});